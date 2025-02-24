using System.Windows;

namespace MilBD;

public partial class NewMIL : Window
{
    public NewMIL()
    {
        InitializeComponent();
    }

    private void Confim_Click(object sender, RoutedEventArgs e)
    {
        var mil = MilBase.AddMil(City.Text, Street.Text, Number.Text, NameM.Text, FamM.Text, FauM.Text);
        MilBase.Ad(mil);
        this.Close();
    }
}