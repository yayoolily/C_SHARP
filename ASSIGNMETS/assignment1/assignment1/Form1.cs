using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating variables 
            String Food1, Food2;
            Double Price_Food1, Price_Food2, Amount_Tips, Sales_Text, Tips_Amount, Total_Amount, Net_Amount ,Full_Pay;

            //constant

            const double Sales_vat=5;
            //const double Tips_vat = 15;

            //assign variables 

            Food1 = txtFood1.Text;
            Price_Food1 = double.Parse(txtPrice_Food1.Text);
            Food2 = txtFood2.Text;
            Price_Food2 = double.Parse(txtPrice_Food2.Text);
            Tips_Amount = double.Parse(txtTips.Text);

            //Calculating 
            try
            {
                Total_Amount = Price_Food1 + Price_Food2;
                Sales_Text = Total_Amount * (Sales_vat / 100);
                //Tips_Amount = Total_Amount * (Tips_vat / 100);
                Full_Pay =Tips_Amount+Sales_Text+Total_Amount;
                Net_Amount = Total_Amount - Sales_Text;

                //display the output

                lblSalesTxt.Text = Sales_Text.ToString("c");
                lblTipsAmount.Text = Tips_Amount.ToString("c");
                lblTotalAmount.Text = Total_Amount.ToString("c");
                lblFullPay.Text = Full_Pay.ToString("c");
                lblNetAmount.Text = Net_Amount.ToString("C");
            }
            catch { }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFood1.Clear();
            txtFood2.Clear();
            txtPrice_Food1.Clear();
            txtPrice_Food2.Clear();
            txtTips.Text = "";
            lblSalesTxt.Text = "";
            lblNetAmount.Text = "";
            lblTipsAmount.Text = "";
            lblTotalAmount.Text = "";
            lblFullPay.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
