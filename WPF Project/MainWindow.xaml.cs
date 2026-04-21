using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(text1.Text) || string.IsNullOrWhiteSpace(text2.Text))
                {
                MessageBox.Show("Fill the text box");
                return;

            }
            if(!int.TryParse(text1.Text, out int nr1))
            {
                MessageBox.Show(" Enter a valid number");
                return;
            }
            if (!int.TryParse(text2.Text, out int nr2))
            {
                MessageBox.Show(" Enter a valid number");
                return;
            }
            switch (combo.SelectedItem.ToString()) {
                case "Plus":
                    {
                        rezult.Content = (nr1 + nr2).ToString();
                        break;
                    }
                case "Minus":
                    {
                        rezult.Content = (nr1 - nr2).ToString();
                        break;
                    }
                case "Multiplication":
                    {
                        rezult.Content = (nr1 * nr2).ToString();
                        break;
                    }
                case "Divider":
                    {
                        rezult.Content = (nr1 / nr2).ToString();
                        break;
                    }
            }
            
        }
    }
}