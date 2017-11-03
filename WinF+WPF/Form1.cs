using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinF_WPF
{
    public partial class FormCalc : Form
    {
        public FormCalc()
        {
            InitializeComponent();
        }

        private void btNum1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            tbScreen.Text += b.Text;
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            tbScreen.Text = tbScreen.Text + " " + b.Text + " ";
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbScreen.Text = "";
        }

        private void btCount_Click(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                res = CountFromString.CountFromString.Input(tbScreen.Text);
            }
            catch(Exception)
            {

            }
            tbScreen.Text = res.ToString();
        }

        private void btNeg_Click(object sender, EventArgs e)
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

        private void tbScreen_TextChanged(object sender, EventArgs e)
        {
            string[] str;
            str = tbScreen.Text.Split(' ');
            if (str.Length > 3) 
                tbScreen.Text = str[0] + " " + str[1] + " " + str[2];
        }
    }
}
