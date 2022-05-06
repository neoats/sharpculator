using System;

using System.Windows.Forms;

namespace sharpculator
{
    public partial class form : Form
    {
        double result = 0.0;
        char function;
        string mem1 = "";
        public form()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            tbx1.Text += "0";
        }

        #region numbers
        private void n1_Click(object sender, EventArgs e)
        {
            tbxempty();
            mem1 += "1";
            tbxReAdder();
        }
        private void n2_Click(object sender, EventArgs e)
        {
            tbxempty();
            mem1 += "2";
            tbxReAdder();
        }

        private void n3_Click(object sender, EventArgs e)
        {
            tbxempty();
            mem1 += "3";
            tbxReAdder();
        }
        private void n4_Click(object sender, EventArgs e)
        {
            tbxempty();
            mem1 += "4";
            tbxReAdder();
        }

        private void n5_Click(object sender, EventArgs e)
        {
            tbxempty();
            mem1 += "5";
            tbxReAdder();
        }

        private void n6_Click(object sender, EventArgs e)
        {
            tbxempty();
            mem1 += "6";
            tbxReAdder();
        }
        private void n7_Click(object sender, EventArgs e)
        {
            tbxempty();
            mem1 += "7";
            tbxReAdder();
        }

        private void n8_Click(object sender, EventArgs e)
        {
            tbxempty();
            mem1 += "8";
            tbxReAdder();
        }

        private void n9_Click(object sender, EventArgs e)
        {
            tbxempty();
            mem1 += "9";
            tbxReAdder();
        }

        private void n0_Click(object sender, EventArgs e)
        {
            tbxempty();
            mem1 += "0";
            tbxReAdder();
        }
        #endregion

        #region ops
        private void btnClear_Click(object sender, EventArgs e)
        {
            mem1 = "";
            tbx1.Clear();
           
        }
        private void btnDivsn_Click(object sender, EventArgs e)
        {

        }

        private void btnMultip_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region local func
        private void tbxempty()
        {
            tbx1.Text = "";
        }
        private void tbxReAdder()
        {
            tbx1.Text += mem1;
        }

        #endregion

    }
}
