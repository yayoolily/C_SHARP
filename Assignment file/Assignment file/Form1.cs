using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Assignment_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreatefile_Click(object sender, EventArgs e)
        {
            //import class 
            StreamWriter writing_file;

            //open the file 
            writing_file = File.CreateText("index.doc");

            //process file 
            writing_file.Write("welcome to files ");
            writing_file.Write(txtBox1.Text);
            listBox1.Items.Add(txtBox1.Text);

            //close the file 
            writing_file.Close();
            MessageBox.Show("CREATED SUCCESFULY ");
        }

        private void btnwriteline_Click(object sender, EventArgs e)
        {
            //import class 
            StreamWriter writing_file;
            //open the file 
            writing_file = File.CreateText("index.doc");

            //process file 
            writing_file.WriteLine("welcome to C# ");
            writing_file.WriteLine(txtBox1.Text);

            listBox1.Items.Add(txtBox1.Text);

            //close the file 
            writing_file.Close();
            MessageBox.Show("CREATED SUCCESFULY ");

        }

        private void btnpath_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath("index.doc");
            MessageBox.Show(path);
        }

        private void btnreadline_Click(object sender, EventArgs e)
        {
            // Clear the list box first, so items are not repeated
            listBox1.Items.Clear();

            //reading files
            //import class
            StreamReader read;

            //open the file 
            read = File.OpenText("index.doc");

            //variable to store item 
            string lines = read.ReadLine();

            //listbox to store the read item 
            listBox1.Items.Add(lines);

            read.Close();
            MessageBox.Show(lines);
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            //import class
            StreamReader read;

            //open the file
            read = File.OpenText("index.doc");

            listBox1.Items.Clear();

            // reading file using while loop
            while (read.EndOfStream == false)
            {
                string lines = read.ReadLine();
                listBox1.Items.Add(lines);
            }

            read.Close();

        }

        private void btnToEnd_Click(object sender, EventArgs e)
        {
            //clear listbox 
            listBox1.Items.Clear();
            //import class
            StreamReader read;

            //open the file 
            read = File.OpenText("index.doc");

            //reading file using readtoend 
            string lines;
            lines = read.ReadToEnd();

            //listbox to store the read item 
            listBox1.Text = lines;

            read.Close();

            MessageBox.Show(lines);

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Check if file exists
            if (!File.Exists("index.doc"))
            {
                MessageBox.Show("file not found ");
                return;
            }
            File.Copy("index.doc", "index.doc_packup", true);

            //delete file 
            File.Delete("index.doc");
            listBox1.Items.Clear ();
            MessageBox.Show("File deleted successfully");
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            // Check if file exists
            if (!File.Exists("index.doc"))
            {
                MessageBox.Show("file not found ");
                return;
            }

            // Check if item is selected
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select item first");
                return;
            }

            // Remove selected item

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            StreamWriter writing_file = File.CreateText("index.doc");

            foreach (var item in listBox1.Items)
                writing_file.WriteLine(item);

            writing_file.Close();

            MessageBox.Show("Item deleted");
        }
    }
}
