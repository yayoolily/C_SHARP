using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string passengerName = txtName.Text;
            bool bookingApproval = true;
            string Reason = "";
            //validate inputs 
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Enter valid passenger age ");
                return;
            }
            if (!int.TryParse(txtTickets.Text, out int tickets))
            {
                MessageBox.Show("Enter valid number of tickets ");
                return;
            }
            if (!int.TryParse(txtBaggageweight.Text, out int baggageweight))
            {
                MessageBox.Show("Enter a valid baggage weight");
                return;
            }
            //check validation rules rules
            if (age < 1 || age > 100)
            {
                MessageBox.Show("Passenger age must be between 1 and 100");
            }
               
            else if (tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Number of tickets must be between  and 100");
            }
                
            else if (baggageweight < 0 || baggageweight > 50)
            {
                MessageBox.Show("Baggage weight must be between 0 and 50 kg");
            }

            //Flight Class  and Ticketprice

            string flightclass = "";
            double ticketprice = 0;
            if (rdofirstclass.Checked)
            {
                flightclass = "firstClass";
                ticketprice = 150;
            }else if (rdonormalclass.Checked)
            {
                flightclass = "NormalClass";
                ticketprice = 80;
            }else if (rdobusinessclass.Checked)
            {
                flightclass = "BusinessClass";
                ticketprice = 300;
            }
            else
            {
                MessageBox.Show("choose  class ");
                return;
            }

            //rule passenger under 12 can`t book firstclass

            if (age <= 12 && rdofirstclass.Checked)
            {
                bookingApproval = false;
                listBox1.Items.Clear();
                listBox1.Items.Add("Booking Status : REJECTED");
                listBox1.Items.Add("Reason: Passenger under 12 can not book firstClass ");
                return;
            }

            //Calculate basic ticket cost 
            double basicTotalCost = ticketprice * tickets;
            double discount = 0;
            if(tickets>=3 && tickets <= 4)
            {
                discount += basicTotalCost * 0.05;
            }else if (tickets == 5)
            {
                discount += basicTotalCost * 0.10;
            }
            //age discount
            if (age < 12)
            {
                discount += basicTotalCost * 0.20;
            }else if (age >= 60)
            {
                discount += basicTotalCost * 0.10;
            }
            double insuranceCost = 0;
            if (chktravel_insurance.Checked) {
                insuranceCost = tickets * 25;
            }
            double finalCost = basicTotalCost - discount + insuranceCost;

            //display booking details
            listBox1.Items.Clear();
            listBox1.Items.Add("PassengerName: " + Name);
            listBox1.Items.Add("PassengerAge: " + age);
            listBox1.Items.Add("flightClass : " + flightclass);
            listBox1.Items.Add("NumberOfTicket: " + tickets);
            listBox1.Items.Add("Baggage Weight: " + baggageweight +"KG");
            listBox1.Items.Add("Basic Total Cost : $" + basicTotalCost);
            listBox1.Items.Add("Discount : $" + discount.ToString("f2"));
            listBox1.Items.Add("Insurance Cost : $ " + insuranceCost.ToString("F2"));
            listBox1.Items.Add("================================== ");
            listBox1.Items.Add("PassengerName: $" +finalCost.ToString("F2"));
            listBox1.Items.Add("Booking Status : APPROVED" );



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtTickets.Clear();
            txtBaggageweight.Clear();
            rdofirstclass.Checked = false;
            rdonormalclass.Checked = false;
            rdobusinessclass.Checked = false;
            chktravel_insurance.Checked = false;
            listBox1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
