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

namespace CalcBtWPF
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

        private void btNum1_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            tbScreen.Text += b.Content;
        }

        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            tbScreen.Text = "";
        }

        private void btPlus_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            tbScreen.Text = tbScreen.Text + " " + b.Content + " ";
        }

        private void btNeg_Click(object sender, RoutedEventArgs e)
        {
            if (tbScreen.Text.Length == 0)
            {
                tbScreen.Text += "-";
                return;
            }

            if (tbScreen.Text == "-")
            {
                tbScreen.Text = "";
                return;
            }

            if (tbScreen.Text[tbScreen.Text.Length - 1] == '-')
            {
                string s = "";
                for (int i = 0; i < tbScreen.Text.Length - 1; i++)
                    s += tbScreen.Text[i];
                tbScreen.Text = s;
            }
            else tbScreen.Text += "-";
        }

        private void btCount_Click(object sender, RoutedEventArgs e)
        {
            int res = 0;
            try
            {
                res = CountFromString.CountFromString.Input(tbScreen.Text);
            }
            catch (Exception)
            {

            }
            tbScreen.Text = res.ToString();
        }

        private void tbScreen_TextChanged(object sender, TextChangedEventArgs e)
        {
            string[] str;
            str = tbScreen.Text.Split(' ');
            if (str.Length > 3)
                tbScreen.Text = str[0] + " " + str[1] + " " + str[2];
        }
    }
}
