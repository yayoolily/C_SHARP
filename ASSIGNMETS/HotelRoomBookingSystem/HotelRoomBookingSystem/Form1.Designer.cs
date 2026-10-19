namespace HotelRoomBookingSystem
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumberNights = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtNumberGuest = new System.Windows.Forms.TextBox();
            this.cmbRoomtype = new System.Windows.Forms.GroupBox();
            this.rdostandard = new System.Windows.Forms.RadioButton();
            this.rdonormal = new System.Windows.Forms.RadioButton();
            this.rdohight = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.chkBreakFast = new System.Windows.Forms.CheckBox();
            this.cmbRoomtype.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1098, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Room Booking System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(40, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personal Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guest Name :";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Guest Age :";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number Of Nights :";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number Of Guest :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(343, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 26);
            this.txtName.TabIndex = 6;
            // 
            // txtNumberNights
            // 
            this.txtNumberNights.Location = new System.Drawing.Point(343, 207);
            this.txtNumberNights.Name = "txtNumberNights";
            this.txtNumberNights.Size = new System.Drawing.Size(239, 26);
            this.txtNumberNights.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(343, 171);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(239, 26);
            this.txtAge.TabIndex = 8;
            // 
            // txtNumberGuest
            // 
            this.txtNumberGuest.Location = new System.Drawing.Point(343, 249);
            this.txtNumberGuest.Name = "txtNumberGuest";
            this.txtNumberGuest.Size = new System.Drawing.Size(239, 26);
            this.txtNumberGuest.TabIndex = 9;
            // 
            // cmbRoomtype
            // 
            this.cmbRoomtype.Controls.Add(this.rdohight);
            this.cmbRoomtype.Controls.Add(this.rdonormal);
            this.cmbRoomtype.Controls.Add(this.rdostandard);
            this.cmbRoomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomtype.Location = new System.Drawing.Point(120, 298);
            this.cmbRoomtype.Name = "cmbRoomtype";
            this.cmbRoomtype.Size = new System.Drawing.Size(523, 93);
            this.cmbRoomtype.TabIndex = 11;
            this.cmbRoomtype.TabStop = false;
            this.cmbRoomtype.Text = "Room Type";
            // 
            // rdostandard
            // 
            this.rdostandard.AutoSize = true;
            this.rdostandard.Location = new System.Drawing.Point(23, 42);
            this.rdostandard.Name = "rdostandard";
            this.rdostandard.Size = new System.Drawing.Size(131, 29);
            this.rdostandard.TabIndex = 0;
            this.rdostandard.TabStop = true;
            this.rdostandard.Text = "Standard ";
            this.rdostandard.UseVisualStyleBackColor = true;
            // 
            // rdonormal
            // 
            this.rdonormal.AutoSize = true;
            this.rdonormal.Location = new System.Drawing.Point(198, 42);
            this.rdonormal.Name = "rdonormal";
            this.rdonormal.Size = new System.Drawing.Size(105, 29);
            this.rdonormal.TabIndex = 1;
            this.rdonormal.TabStop = true;
            this.rdonormal.Text = "Normal";
            this.rdonormal.UseVisualStyleBackColor = true;
            // 
            // rdohight
            // 
            this.rdohight.AutoSize = true;
            this.rdohight.Location = new System.Drawing.Point(382, 42);
            this.rdohight.Name = "rdohight";
            this.rdohight.Size = new System.Drawing.Size(87, 29);
            this.rdohight.TabIndex = 2;
            this.rdohight.TabStop = true;
            this.rdohight.Text = "Hight";
            this.rdohight.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBreakFast);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(120, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aditional Options";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Booking Details"});
            this.listBox1.Location = new System.Drawing.Point(794, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(316, 464);
            this.listBox1.TabIndex = 13;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(54, 538);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(178, 56);
            this.btncalculate.TabIndex = 14;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(284, 538);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(178, 56);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(502, 538);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(178, 56);
            this.btnexit.TabIndex = 16;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkBreakFast
            // 
            this.chkBreakFast.AutoSize = true;
            this.chkBreakFast.Location = new System.Drawing.Point(40, 47);
            this.chkBreakFast.Name = "chkBreakFast";
            this.chkBreakFast.Size = new System.Drawing.Size(387, 29);
            this.chkBreakFast.TabIndex = 0;
            this.chkBreakFast.Text = "BreakFast (10 Per Guest Per nights)";
            this.chkBreakFast.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1115, 645);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbRoomtype);
            this.Controls.Add(this.txtNumberGuest);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtNumberNights);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cmbRoomtype.ResumeLayout(false);
            this.cmbRoomtype.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumberNights;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtNumberGuest;
        private System.Windows.Forms.GroupBox cmbRoomtype;
        private System.Windows.Forms.RadioButton rdohight;
        private System.Windows.Forms.RadioButton rdonormal;
        private System.Windows.Forms.RadioButton rdostandard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.CheckBox chkBreakFast;
    }
}

