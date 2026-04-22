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
            rezult.Content = "Click on Calculate";
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
            if (combo.SelectedItem == null)
            {
                MessageBox.Show("Please select an operation (Plus, Minus, etc.)");
                return;
            }


            var selectedItem = (ComboBoxItem)combo.SelectedItem;
            switch (selectedItem.Content.ToString()) {
                case "Plus":
                    {
                        rezult.Content = "The sum is "+(nr1 + nr2).ToString();
                    }
                    break;
                case "Minus":
                    {
                        rezult.Content = "The answer is " + (nr1 - nr2).ToString();
                        break;
                    }
                case "Multiplication":
                    {
                        rezult.Content = "The product is " + (nr1 * nr2).ToString();
                        break;
                    }
                case "Division":
                    {
                        rezult.Content = "The answer is " + (nr1 / nr2).ToString();
                        break;
                    }
            }
            // Use Keyboard.FocusedElement instead of FocusManager
            IInputElement focusedElement = Keyboard.FocusedElement;

            if (focusedElement == text1 || focusedElement == text2 || focusedElement == combo)
            {
                eraseTextBox();
            }

        }
        private void eraseTextBox()
        {
            text1.Text = "";
            text2.Text = "";
            rezult.Content = "";
        }
        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(rezult!=null)
            rezult.Content = "Click on Calculate";

        }

        private void text1_TextChanged(object sender, TextChangedEventArgs e)
        {
            rezult.Content = "Click on Calculate";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            eraseTextBox();
        }

        private void text2_TextChanged(object sender, TextChangedEventArgs e)
        {
            rezult.Content = "Click on Calculate";
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            
        }
    }
}