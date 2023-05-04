using System;

using System.Windows.Forms;
using sharpculator.Buttons;

namespace sharpculator
{
    public partial class xY : Form
    {
      static  double result = 0.0;
      static char function;
      static string mem1 = "";
      Numbers numbers = new Numbers();
     

        public xY()
        {
            InitializeComponent();

        }
        

        public void Form1_Load(object sender, EventArgs e)
        {
            tbx1.Text += "0";
        }

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
      
        private void btnClear_Click(object sender, EventArgs e)
        {
            mem1 = "";
            tbx1.Clear();
           
        }
    

        public void tbxempty()
        {
            tbx1.Text = "";
        }
        public void tbxReAdder()
        {
            tbx1.Text += mem1;
        }


        private void btnEqual_Click_1(object sender, EventArgs e)
        {
            result = function switch
            {
                '+' => result + Convert.ToDouble(mem1),
                '-' => result - Convert.ToDouble(mem1),
                'x' => result * Convert.ToDouble(mem1),
                '÷' => result / Convert.ToDouble(mem1),
                'p' => power.Invoke(result, Convert.ToInt32(mem1)),

                _ => result // Default case
            };

            tbx1.Text = result.ToString();
            mem1 = "";
        }
        private void btnDivsn_Click(object sender, EventArgs e)
        {

            function = '÷';
            result = Convert.ToDouble(mem1);
            mem1 = "";
            tbx1.Text = "0";
        }



        private void btnMultip_Click(object sender, EventArgs e)
        {
            function = 'x';
            result = Convert.ToDouble(mem1);
            mem1 = "";
            tbx1.Text = "0";
        }

        private void btnSubs_Click(object sender, EventArgs e)
        {

            function = '-';
            result = Convert.ToDouble(mem1);
            mem1 = "";
            tbx1.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            function = '+';
            result = Convert.ToDouble(mem1);
            mem1 = "";
            tbx1.Text = "0";
        }

        private void xSqr_Click(object sender, EventArgs e)
        {
            var n1 = Convert.ToInt32(tbx1.Text);
            result = n1 * n1;
            mem1 = "";
            tbx1.Text = result.ToString();


        }
        private long previousResult = 0;




        private void xYmltp_Click(object sender, EventArgs e)
        {
            function = 'p';
            mem1 = "0";
            if (double.TryParse(tbx1.Text, out double x))
            {
                result = x;
                mem1 = "";
            }
        }
 
         Func<double, int,  double> power = (x, n) =>
         {
             double pow = 1.0;

             for (int i = 0; i < n; i++)
             {
                 pow *= x;
             }

             return pow ;
         };
         
    }
}

