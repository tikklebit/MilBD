using System.Windows;

namespace MilBD;

public partial class Search : Window
{

    public Search()
    {
        InitializeComponent();
    }
    
    private void Search_Click(object sender, RoutedEventArgs e)
    {
        MilBase.ShowInfo(InputTextBox.Text);
    }
}