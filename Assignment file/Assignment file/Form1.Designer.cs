namespace Assignment_file
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncreatefile = new System.Windows.Forms.Button();
            this.btnwriteline = new System.Windows.Forms.Button();
            this.btnreadline = new System.Windows.Forms.Button();
            this.btnpath = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btnToEnd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncreatefile
            // 
            this.btncreatefile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btncreatefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatefile.Location = new System.Drawing.Point(28, 45);
            this.btncreatefile.Name = "btncreatefile";
            this.btncreatefile.Size = new System.Drawing.Size(200, 64);
            this.btncreatefile.TabIndex = 0;
            this.btncreatefile.Text = "Creating New File";
            this.btncreatefile.UseVisualStyleBackColor = false;
            this.btncreatefile.Click += new System.EventHandler(this.btncreatefile_Click);
            // 
            // btnwriteline
            // 
            this.btnwriteline.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnwriteline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwriteline.Location = new System.Drawing.Point(28, 125);
            this.btnwriteline.Name = "btnwriteline";
            this.btnwriteline.Size = new System.Drawing.Size(200, 64);
            this.btnwriteline.TabIndex = 1;
            this.btnwriteline.Text = "Creating New File Writeline";
            this.btnwriteline.UseVisualStyleBackColor = false;
            this.btnwriteline.Click += new System.EventHandler(this.btnwriteline_Click);
            // 
            // btnreadline
            // 
            this.btnreadline.BackColor = System.Drawing.SystemColors.Info;
            this.btnreadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadline.Location = new System.Drawing.Point(28, 206);
            this.btnreadline.Name = "btnreadline";
            this.btnreadline.Size = new System.Drawing.Size(200, 64);
            this.btnreadline.TabIndex = 2;
            this.btnreadline.Text = "Reading The File Using Readline";
            this.btnreadline.UseVisualStyleBackColor = false;
            this.btnreadline.Click += new System.EventHandler(this.btnreadline_Click);
            // 
            // btnpath
            // 
            this.btnpath.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpath.Location = new System.Drawing.Point(386, 34);
            this.btnpath.Name = "btnpath";
            this.btnpath.Size = new System.Drawing.Size(200, 64);
            this.btnpath.TabIndex = 3;
            this.btnpath.Text = "Create New File Path";
            this.btnpath.UseVisualStyleBackColor = false;
            this.btnpath.Click += new System.EventHandler(this.btnpath_Click);
            // 
            // btnread
            // 
            this.btnread.BackColor = System.Drawing.SystemColors.Info;
            this.btnread.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnread.Location = new System.Drawing.Point(352, 125);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(234, 64);
            this.btnread.TabIndex = 4;
            this.btnread.Text = "Reading The File Using Read() while loope";
            this.btnread.UseVisualStyleBackColor = false;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnToEnd
            // 
            this.btnToEnd.BackColor = System.Drawing.SystemColors.Info;
            this.btnToEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToEnd.Location = new System.Drawing.Point(386, 206);
            this.btnToEnd.Name = "btnToEnd";
            this.btnToEnd.Size = new System.Drawing.Size(200, 64);
            this.btnToEnd.TabIndex = 5;
            this.btnToEnd.Text = "Reading The File Using ReadtoEnd";
            this.btnToEnd.UseVisualStyleBackColor = false;
            this.btnToEnd.Click += new System.EventHandler(this.btnToEnd_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "RESULT :"});
            this.listBox1.Location = new System.Drawing.Point(855, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 364);
            this.listBox1.TabIndex = 6;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(28, 301);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(200, 64);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete File";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.RosyBrown;
            this.btnItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem.Location = new System.Drawing.Point(386, 316);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(200, 64);
            this.btnItem.TabIndex = 8;
            this.btnItem.Text = "Delete Item";
            this.btnItem.UseVisualStyleBackColor = false;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(630, 71);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(161, 26);
            this.txtBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 547);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnToEnd);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnpath);
            this.Controls.Add(this.btnreadline);
            this.Controls.Add(this.btnwriteline);
            this.Controls.Add(this.btncreatefile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreatefile;
        private System.Windows.Forms.Button btnwriteline;
        private System.Windows.Forms.Button btnreadline;
        private System.Windows.Forms.Button btnpath;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnToEnd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.TextBox txtBox1;
    }
}

