using System;
using System.Windows.Forms;

namespace CalcTb
{
    public partial class fCalcTb : Form
    {
        public fCalcTb()
        {
            InitializeComponent();
        }

        private void btCount_Click(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                res =  CountFromString.CountFromString.Input(tbA.Text, tbB.Text, tbO.Text);
            }
            catch(Exception)
            { };
            tbA.Text = res.ToString();
            tbB.Text = "";
            tbO.Text = "";
        }
    }
}
