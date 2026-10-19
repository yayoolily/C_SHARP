using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Fee_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string studentname = txtstudentname.Text;

                if (!int.TryParse(txtstudentid.Text, out int ID)) {
                    MessageBox.Show("enter a valid id ");
                    return;
                }

                if (!int.TryParse(txtcourses.Text, out int Courses))
                {
                    MessageBox.Show("nter valid course");
                    return;
                }
                if(!int.TryParse(txtstudylevel.Text, out int studylevel))
                {
                    MessageBox.Show("enter a valid study level");
                    return;
                }
                if (!double.TryParse(txttransportfee.Text, out double transportfee))
                {
                    MessageBox.Show("enter a valid transport fee");
                    return;
                }

                //transport fee can not be negative
                if (transportfee < 0)
                {
                    MessageBox.Show("Transport fee cannot be negative");
                    return;
                }


                if (Courses<1 || Courses > 8)
                {
                    MessageBox.Show("Number of courses must be between 1 and 8.");
                    return;
                }
                // determine fee per course
                double feepercourse = 0;
                if (studylevel == 1)
                {
                    feepercourse = 40;
                }
                else if (studylevel == 2) {
                    feepercourse = 45;
                }else if(studylevel == 3)
                {
                    feepercourse = 50;
                }else if (studylevel == 4)
                {
                    feepercourse = 55;
                }else
                {
                    MessageBox.Show("please enter study level  ");
               
                    return;
                }
                // calculate tuition fee 
                double tuitionfee = Courses * feepercourse;

                // add 120$ accomondation is select 
                double accommodation = 0;
                if (chkAccommodation.Checked) {
                    accommodation = 120;
                }
                if (chktransport.Checked)
                {
                    transportfee = 50;
                }
                //apply discount 
                double discountrate = 0;

                if (Courses >= 6)
                {
                    discountrate = 0.10;
                }

                //additional 5% service discount 
                if(chkAccommodation.Checked && chktransport.Checked && Courses >= 5)
                {
                    discountrate += 0.05;
                }
                double discount = tuitionfee * discountrate;

                //calculate final egistration 
                double finalamount = tuitionfee + transportfee+accommodation - discount;

                //display result in lbl
                lblnameresult.Text = "name: " + studentname;
                lblidresult.Text="StudentID: "+ID;
                lblcourseresult.Text = "Number Courses: " + Courses;
                lblstudyyear.Text = "Study years: " + studylevel;
                lblfeeresult.Text = "Transport Fee : $" + transportfee.ToString();
                lbldiscount.Text = "Discount: " + discount.ToString();
                lbltuitionresult.Text = "Tuition Fee: $" + tuitionfee.ToString();
                lblfinalamount.Text = "FinalAmount: $" + finalamount.ToString();

            }
            catch
            {
                MessageBox.Show("Try again ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear textbox
            txtstudentname.Clear();
            txtstudentid.Clear();
            txtstudylevel.Clear();
            txttransportfee.Clear();
            txtcourses.Clear();

            //clear label 
            lblnameresult.Text = string.Empty;
            lblidresult.Text= string.Empty;
            lblcourseresult.Text = string.Empty;    
            lblfeeresult.Text= string.Empty;
            lblstudyyear.Text= string.Empty;
            lbldiscount.Text= string.Empty;
            lbltuitionresult.Text= string.Empty;
            lblfinalamount.Text= string.Empty;

            //checkbox clear 
            chkAccommodation.Checked = false;
            chktransport.Checked = false;

            txtstudentname.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
