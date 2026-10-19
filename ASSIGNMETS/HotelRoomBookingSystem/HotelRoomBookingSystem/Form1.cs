using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRoomBookingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //validate guest name
            string guestname = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(guestname)) {
                MessageBox.Show("guestname can not be empty");
                txtName.Focus();
                return;

            }
            //validate numeric inputs using tryparse
            if (!int.TryParse(txtAge.Text, out int guestage))
            {
                MessageBox.Show("please enter a valid age.");
                txtAge.Focus();
                return;
            }
            if (!int.TryParse(txtNumberNights.Text, out int nights))
            {
                MessageBox.Show("pls enter a valid number of nights");
                txtNumberNights.Focus();
                return;
            }
            if (!int.TryParse(txtNumberGuest.Text, out int guests))
            {
                MessageBox.Show("pls enter a valid number of nights");
                txtNumberNights.Focus();
                return;
            }
            //validate age , nights , guest
            if(guestage<18 & guestage > 90)
            {
                MessageBox.Show("guest age must be between 18 and 90");
                return;
            }
            if(nights<1 & nights > 30)
            {
                MessageBox.Show("Number of nights must be between 1 and 30 ");
                return;
            }
            if(guests< 1 & guests > 6)
            {
                MessageBox.Show("number of guests must be between 1 and 6 ");
                return;
            }
            // get room type using radiobutton 

            string roomtype = "";

            if (rdostandard.Checked)
            {
                roomtype = "Standard";
            }else if (rdonormal.Checked)
            {
                roomtype = "Normal";
            }else if (rdohight.Checked)
            {
                roomtype = "Hight";
            }else
            {
                MessageBox.Show("please select a roomtype ");
                return;
            }

            //check booking approval using bool
            bool isApproved = true;
            if (rdostandard.Checked & guests > 2) {
                isApproved= false;
            }else if (rdonormal.Checked & guests > 4)
            {
                isApproved= false;
            }else if (rdohight.Checked & guests > 6)
            {
                isApproved= false;
            }
            if (isApproved)
            {
                MessageBox.Show("Booking rejected ! Too  many guests for this room");
                return;
            }
            //determine room rate using switch
            double ratePerNight = 0;
            switch (roomtype)
            {
                case "Standard":
                    ratePerNight = 50;
                    break;

                case "Normal":
                    ratePerNight = 80;
                    break;

                case "Hight":
                    ratePerNight = 130;
                    break;
                default:
                    MessageBox.Show("Invalid room type.");
                    return;

            }

            //calculate basic room cost 
            double basicRoomCost = ratePerNight * nights;

            //calculate stay discount 
            double discount = 0;
            if (nights >= 10)
            {
                discount = basicRoomCost * 12;
            }else if (nights >= 5)
            {
                discount = basicRoomCost * 0.05;
            }

            //calculate breakfast cost 
            double breakfast = 0;
            if (chkBreakFast.Checked)
            {
                breakfast = 10 * guests * nights;
            }
            //calculate service surcharge
            double serviceSurcharge = 0;
            if (guests > 4)
            {
                serviceSurcharge = basicRoomCost * 0.05;
            }
            //calculate senior discount
            double senior_discount = 0;
            if (guests >= 60)
            {
                senior_discount = basicRoomCost * 0.05;
            }

            //calculate finalcost 
            double finalcost = basicRoomCost - discount - senior_discount + breakfast + serviceSurcharge;
             //display booking details 
             listBox1.Items.Clear();
            listBox1.Items.Add("Guest Name: " + guestname);
            listBox1.Items.Add("Guest age: " + guestage);
            listBox1.Items.Add("Number of Nights: " + nights);
            listBox1.Items.Add("Number Of Guest: " + guests);
            listBox1.Items.Add("RoomType : " + roomtype);
            listBox1.Items.Add("Rate_Per_Night: " + ratePerNight.ToString("F2"));
            listBox1.Items.Add("Basic Room Cost: " + basicRoomCost.ToString("F2"));
            listBox1.Items.Add("Senior discount : " +senior_discount.ToString("F2"));
            listBox1.Items.Add("BreakFast Cost : " + breakfast.ToString("F2"));
            listBox1.Items.Add("Service Surcharge: " + serviceSurcharge.ToString("F2"));
            listBox1.Items.Add("FinalCost  : $" + finalcost.ToString("F2"));
            listBox1.Items.Add("Booking Status: APPROVED");

            MessageBox.Show("Booking approved successfully!\nFinal Cost: $ " + finalcost.ToString("F2"));





        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtNumberNights.Clear();
            txtNumberGuest.Clear();
            rdostandard.Checked = false;
            rdonormal.Checked = false;
            rdohight.Checked = false;   
            chkBreakFast.Checked = false;
            listBox1.Items.Clear();
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
