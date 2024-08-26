using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            MessageBox.Show("Password button clicked!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
            MessageBox.Show("Submit button clicked!");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
            MessageBox.Show("Login button clicked!");
        }
    }
}
