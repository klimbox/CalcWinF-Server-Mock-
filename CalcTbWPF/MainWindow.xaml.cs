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

namespace CalcTbWPF
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
        
        private void btCount_Click(object sender, RoutedEventArgs e)
        {
            int res = 0;
            try
            {
                res = CountFromString.CountFromString.Input(tbA.Text, tbB.Text, tbOperation.Text);
            }
            catch (Exception)
            { };
            tbA.Text = res.ToString();
            tbB.Text = "";
            tbOperation.Text = "";
        }
    }
}
