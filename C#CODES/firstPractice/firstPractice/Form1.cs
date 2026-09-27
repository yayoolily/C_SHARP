using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //display message using messagebox.

            MessageBox.Show("welcome to C#");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("go to your class now!");
        }
    }
}
