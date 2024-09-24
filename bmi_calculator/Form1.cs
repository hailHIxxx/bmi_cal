using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmi_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str_h = heigh_value.Text;
            string str_w = weight_value.Text;
           
            bool null_h = String.IsNullOrEmpty(str_h);
            bool null_w = String.IsNullOrEmpty(str_w);
            if (null_h == true || null_w == true)
            {
                MessageBox.Show("!! Are you forget something !!", "result");
                goto stop;
            }
                    
            for (int i = 0; i <= str_h.Length -1; i++)
            {
                bool qq = Char.IsLetter(str_h, i);
                if (qq == true)
                {
                    MessageBox.Show("!! Can't put an alphabet here !!", "result");
                    goto stop;
                }
            }
            for (int j = 0; j <= str_w.Length -1; j++)
            {
                bool pp = Char.IsLetter(str_w, j);
                if (pp == true)
                {
                    MessageBox.Show("!! Can't put an alphabet here !!", "result");
                    goto stop;
                }
            }

            double d_h = Convert.ToDouble(str_h);
            double d_w = Convert.ToDouble(str_w);

            if (d_h <= 0 || d_w <= 0)
            {
                MessageBox.Show("!! Your weight or height can't be 0 !!", "result");
                goto stop;
            }

            d_h = d_h * 0.01;

            double bmi = d_w / Math.Pow(d_h, 2);

            string ans = "";
            ans = bmi.ToString("F1");

            if (bmi < 18.5)
            {
                MessageBox.Show("Your BMI is " + ans.ToString() + Environment.NewLine + "Under weight", "result");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                MessageBox.Show("Your BMI is " + ans.ToString() + Environment.NewLine + "Normal", "result");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                MessageBox.Show("Your BMI is " + ans.ToString() + Environment.NewLine + "Over weight", "result");
            }
            else if (bmi >= 30 && bmi < 35)
            {
                MessageBox.Show("Your BMI is " + ans.ToString() + Environment.NewLine + "Obese", "result");
            }
            else
            {
                MessageBox.Show("Your BMI is " + ans.ToString() + Environment.NewLine + "Extremely obese", "result");
            }
            stop:;
        }
    }
}
