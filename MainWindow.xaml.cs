using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Background != Brushes.Black)
                button.Background = Brushes.Lime;
            else
                button.Background = Brushes.White;
        }
        private void ColourButton_Click(object sender, RoutedEventArgs e)
        {
            if (RedButton.IsChecked == true)
            {
                ColourButton.Background = Brushes.Red;
            }
            if (YellowButton.IsChecked == true)
            {
                ColourButton.Background = Brushes.Yellow;
            }
            else if (GreenButton.IsChecked == true)
            {
                ColourButton.Background = Brushes.Green;
            }
        }
    }
}
