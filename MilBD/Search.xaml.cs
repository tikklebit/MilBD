using System.Windows;

namespace MilBD;

public partial class Search : Window
{
    public MilBase _milBase = new MilBase();
    public Search()
    {
        InitializeComponent();
    }
    
    private void Search_Click(object sender, RoutedEventArgs e)
    {
        _milBase.ShowInfo(SearchTextBox.Text);
    }

    private void Delete_Click(object sender, RoutedEventArgs e)
    {
        _milBase.DelInfo(SearchTextBox.Text);
    }
}