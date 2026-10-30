using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtweight.Text, out double weight)) {
                MessageBox.Show("enter a valid weight");
                txtweight.Focus();

                return;
            }
            if(!double.TryParse(txtheight.Text, out double height)){
                MessageBox.Show("enter a valid height");

                txtheight.Focus();
                return;

            }

            if (weight < 0)
            {
                MessageBox.Show("weight can not be negative");
                return;
            }
            if (height < 0)
            {
                MessageBox.Show("height can not be negative");
                return;
            }
            double bmi = weight / (height * height);
            if (bmi < 18.5)
            {
                MessageBox.Show("Underweight");
              
            }
            else if (bmi > 18.5 || bmi < 25)
            {
                MessageBox.Show("Optimal weight");
                
            } else if (bmi > 25)
            {
                MessageBox.Show("Overweight");
                
            }else
            {
                MessageBox.Show("enter correct bmi ");
            }

            //displayinfo
            lblweight.Text="weight: "+weight.ToString();
            lblheight.Text="height: "+height.ToString();
            lblbmi.Text="bmi: "+bmi.ToString();
           

        }
    }
}
