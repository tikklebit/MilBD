using System.Windows;
using System.Windows.Documents;

namespace MilBD
{
    public partial class MainWindow : Window
    {
        private ClassMain main = new ClassMain();
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ButtonWrite(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(text.Text) && !N.Items.Contains(text.Text))
            {
                N.Items.Add(text.Text);
                main.WriteToList(text.Text);
                text.Clear();
            }
        }

        private void ButtonSend(object sender, RoutedEventArgs e)
        {
            bool tf = main.ReadList(text2.Text);
            if (tf)
            {
                X.Items.Add(text2.Text);
                text2.Clear();
            }
            else
            {
                MessageBox.Show("Имени не существует в бд");
                text2.Clear();
            }
        }
    }
}