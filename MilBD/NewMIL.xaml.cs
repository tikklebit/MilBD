using System.Windows;

namespace MilBD;

public partial class NewMIL : Window
{
    public MilBase _milBase = new MilBase();
    public NewMIL()
    {
        InitializeComponent();
    }

    private void Confim_Click(object sender, RoutedEventArgs e)
    {
        var mil = _milBase.AddMil(City.Text, Street.Text, Number.Text, NameM.Text, FamM.Text, FauM.Text);
        _milBase.AddInfo(mil);
        this.Close();
    }
}