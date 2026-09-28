using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELLO😊");
        }

        private void ansLabel_Click(object sender, EventArgs e)
        {
            // to create label 
            ansLabel.Text = "how are you friend";

            //to clear label
            ansLabel.Text = "";
            // or you can use String empty
            ansLabel.Text = string.Empty;


        }
    }
}
