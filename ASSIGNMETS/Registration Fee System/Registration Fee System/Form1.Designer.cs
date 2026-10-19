namespace Registration_Fee_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtcourses = new System.Windows.Forms.TextBox();
            this.txttransportfee = new System.Windows.Forms.TextBox();
            this.txtstudylevel = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblnameresult = new System.Windows.Forms.Label();
            this.lblidresult = new System.Windows.Forms.Label();
            this.lblcourseresult = new System.Windows.Forms.Label();
            this.lblstudyyear = new System.Windows.Forms.Label();
            this.lblfeeresult = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.lbltuitionresult = new System.Windows.Forms.Label();
            this.lblfinalamount = new System.Windows.Forms.Label();
            this.chkAccommodation = new System.Windows.Forms.CheckBox();
            this.chktransport = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Fee System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Student Name:";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter StudentID:";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Number of Courses:";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Study Level:";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Transport fee";
            // 
            // txtstudentname
            // 
            this.txtstudentname.Location = new System.Drawing.Point(315, 86);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(198, 26);
            this.txtstudentname.TabIndex = 0;
            // 
            // txtstudentid
            // 
            this.txtstudentid.AllowDrop = true;
            this.txtstudentid.Location = new System.Drawing.Point(315, 119);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(198, 26);
            this.txtstudentid.TabIndex = 1;
            // 
            // txtcourses
            // 
            this.txtcourses.Location = new System.Drawing.Point(315, 150);
            this.txtcourses.Name = "txtcourses";
            this.txtcourses.Size = new System.Drawing.Size(198, 26);
            this.txtcourses.TabIndex = 2;
            // 
            // txttransportfee
            // 
            this.txttransportfee.Location = new System.Drawing.Point(315, 218);
            this.txttransportfee.Name = "txttransportfee";
            this.txttransportfee.Size = new System.Drawing.Size(198, 26);
            this.txttransportfee.TabIndex = 4;
            // 
            // txtstudylevel
            // 
            this.txtstudylevel.Location = new System.Drawing.Point(315, 182);
            this.txtstudylevel.Name = "txtstudylevel";
            this.txtstudylevel.Size = new System.Drawing.Size(198, 26);
            this.txtstudylevel.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Green;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(93, 283);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(136, 51);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(255, 283);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 51);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(458, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 51);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblnameresult
            // 
            this.lblnameresult.BackColor = System.Drawing.Color.Transparent;
            this.lblnameresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnameresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameresult.ForeColor = System.Drawing.Color.Green;
            this.lblnameresult.Location = new System.Drawing.Point(75, 474);
            this.lblnameresult.Name = "lblnameresult";
            this.lblnameresult.Size = new System.Drawing.Size(241, 27);
            this.lblnameresult.TabIndex = 15;
            this.lblnameresult.Text = "label7";
            // 
            // lblidresult
            // 
            this.lblidresult.BackColor = System.Drawing.Color.Transparent;
            this.lblidresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblidresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidresult.ForeColor = System.Drawing.Color.Green;
            this.lblidresult.Location = new System.Drawing.Point(75, 511);
            this.lblidresult.Name = "lblidresult";
            this.lblidresult.Size = new System.Drawing.Size(241, 27);
            this.lblidresult.TabIndex = 16;
            this.lblidresult.Text = "label8";
            // 
            // lblcourseresult
            // 
            this.lblcourseresult.BackColor = System.Drawing.Color.Transparent;
            this.lblcourseresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcourseresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourseresult.ForeColor = System.Drawing.Color.Green;
            this.lblcourseresult.Location = new System.Drawing.Point(75, 558);
            this.lblcourseresult.Name = "lblcourseresult";
            this.lblcourseresult.Size = new System.Drawing.Size(241, 27);
            this.lblcourseresult.TabIndex = 17;
            this.lblcourseresult.Text = "label9";
            // 
            // lblstudyyear
            // 
            this.lblstudyyear.BackColor = System.Drawing.Color.Transparent;
            this.lblstudyyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblstudyyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudyyear.ForeColor = System.Drawing.Color.Green;
            this.lblstudyyear.Location = new System.Drawing.Point(75, 595);
            this.lblstudyyear.Name = "lblstudyyear";
            this.lblstudyyear.Size = new System.Drawing.Size(241, 27);
            this.lblstudyyear.TabIndex = 18;
            this.lblstudyyear.Text = "label10";
            // 
            // lblfeeresult
            // 
            this.lblfeeresult.BackColor = System.Drawing.Color.Transparent;
            this.lblfeeresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfeeresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfeeresult.ForeColor = System.Drawing.Color.Green;
            this.lblfeeresult.Location = new System.Drawing.Point(458, 460);
            this.lblfeeresult.Name = "lblfeeresult";
            this.lblfeeresult.Size = new System.Drawing.Size(256, 27);
            this.lblfeeresult.TabIndex = 19;
            this.lblfeeresult.Text = "label11";
            // 
            // lbldiscount
            // 
            this.lbldiscount.BackColor = System.Drawing.Color.Transparent;
            this.lbldiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.ForeColor = System.Drawing.Color.Green;
            this.lbldiscount.Location = new System.Drawing.Point(458, 494);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(256, 27);
            this.lbldiscount.TabIndex = 20;
            this.lbldiscount.Text = "label12";
            // 
            // lbltuitionresult
            // 
            this.lbltuitionresult.BackColor = System.Drawing.Color.Transparent;
            this.lbltuitionresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltuitionresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltuitionresult.ForeColor = System.Drawing.Color.Green;
            this.lbltuitionresult.Location = new System.Drawing.Point(458, 535);
            this.lbltuitionresult.Name = "lbltuitionresult";
            this.lbltuitionresult.Size = new System.Drawing.Size(256, 27);
            this.lbltuitionresult.TabIndex = 21;
            this.lbltuitionresult.Text = "label13";
            // 
            // lblfinalamount
            // 
            this.lblfinalamount.BackColor = System.Drawing.Color.Transparent;
            this.lblfinalamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfinalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinalamount.ForeColor = System.Drawing.Color.Green;
            this.lblfinalamount.Location = new System.Drawing.Point(458, 587);
            this.lblfinalamount.Name = "lblfinalamount";
            this.lblfinalamount.Size = new System.Drawing.Size(256, 27);
            this.lblfinalamount.TabIndex = 22;
            this.lblfinalamount.Text = "label14";
            // 
            // chkAccommodation
            // 
            this.chkAccommodation.AutoSize = true;
            this.chkAccommodation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkAccommodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAccommodation.Location = new System.Drawing.Point(124, 389);
            this.chkAccommodation.Name = "chkAccommodation";
            this.chkAccommodation.Size = new System.Drawing.Size(163, 24);
            this.chkAccommodation.TabIndex = 5;
            this.chkAccommodation.Text = "Accommodation";
            this.chkAccommodation.UseVisualStyleBackColor = false;
            // 
            // chktransport
            // 
            this.chktransport.AutoSize = true;
            this.chktransport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chktransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chktransport.Location = new System.Drawing.Point(329, 389);
            this.chktransport.Name = "chktransport";
            this.chktransport.Size = new System.Drawing.Size(112, 24);
            this.chktransport.TabIndex = 6;
            this.chktransport.Text = "Transport";
            this.chktransport.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.chktransport);
            this.Controls.Add(this.chkAccommodation);
            this.Controls.Add(this.lblfinalamount);
            this.Controls.Add(this.lbltuitionresult);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.lblfeeresult);
            this.Controls.Add(this.lblstudyyear);
            this.Controls.Add(this.lblcourseresult);
            this.Controls.Add(this.lblidresult);
            this.Controls.Add(this.lblnameresult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtstudylevel);
            this.Controls.Add(this.txttransportfee);
            this.Controls.Add(this.txtcourses);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtstudentname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtcourses;
        private System.Windows.Forms.TextBox txttransportfee;
        private System.Windows.Forms.TextBox txtstudylevel;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblnameresult;
        private System.Windows.Forms.Label lblidresult;
        private System.Windows.Forms.Label lblcourseresult;
        private System.Windows.Forms.Label lblstudyyear;
        private System.Windows.Forms.Label lblfeeresult;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label lbltuitionresult;
        private System.Windows.Forms.Label lblfinalamount;
        private System.Windows.Forms.CheckBox chkAccommodation;
        private System.Windows.Forms.CheckBox chktransport;
    }
}

