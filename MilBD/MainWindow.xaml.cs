using System.Windows;
using System.Reflection;
using System.Windows.Documents;

namespace MilBD
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DisplayVersion();
        }
        
        private void DisplayVersion()
        {
            // Получение версии сборки из AssemblyInfo
            Version? version = Assembly.GetEntryAssembly()?.GetName().Version;
            string? versionString = version?.ToString();

            // Вывод версии в TextBlock (предполагается, что TextBlock с именем versionTextBlock есть в XAML)
            Author.Text = $"Version {versionString} Beta";
        }

        private void CreateMil_Click(object sender, RoutedEventArgs e)
        {
            NewMIL newMil = new NewMIL();
            newMil.Show();
        }
        
        private void CreateSold_Click(object sender, RoutedEventArgs e)
        {
            NewOf newOf = new NewOf();
            newOf.Show();
        }
        
        private void CreateOfficer_Click(object sender, RoutedEventArgs e)
        {
            NewSold newSold = new NewSold();
            newSold.Show();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Search search = new Search();
            search.Show();
        }
    }
}