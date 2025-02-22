using System.Windows;
using System.Windows.Documents;

namespace MilBD
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
    }
}