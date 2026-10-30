namespace BMI
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
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblweight = new System.Windows.Forms.Label();
            this.lblheight = new System.Windows.Forms.Label();
            this.lblbmi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Weight:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter height:";
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(268, 66);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(184, 26);
            this.txtweight.TabIndex = 0;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(268, 103);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(184, 26);
            this.txtheight.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(147, 177);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(109, 52);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblweight
            // 
            this.lblweight.Location = new System.Drawing.Point(94, 286);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(253, 27);
            this.lblweight.TabIndex = 3;
            this.lblweight.Text = "label3";
            // 
            // lblheight
            // 
            this.lblheight.Location = new System.Drawing.Point(94, 326);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(230, 22);
            this.lblheight.TabIndex = 4;
            this.lblheight.Text = "label3";
            // 
            // lblbmi
            // 
            this.lblbmi.Location = new System.Drawing.Point(94, 371);
            this.lblbmi.Name = "lblbmi";
            this.lblbmi.Size = new System.Drawing.Size(253, 23);
            this.lblbmi.TabIndex = 5;
            this.lblbmi.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblbmi);
            this.Controls.Add(this.lblheight);
            this.Controls.Add(this.lblweight);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.Label lblbmi;
    }
}

