using System.Windows;

namespace MilBD;

public partial class NewMIL : Window
{
    // private MilBase _milBase = new MilBase();
    public NewMIL()
    {
        InitializeComponent();
    }

    private void Confim_Click(object sender, RoutedEventArgs e)
    {
        MilBaseInfo info = MilBase.AddMil(City.Text, Street.Text, Number.Text, NameM.Text, FamM.Text, FauM.Text);
        this.Close();
    }
}