namespace picbox_prac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnText = new System.Windows.Forms.Button();
            this.displaylbl = new System.Windows.Forms.Label();
            this.clearlbl = new System.Windows.Forms.Button();
            this.closeform = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnText
            // 
            this.btnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnText.Location = new System.Drawing.Point(32, 58);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(124, 69);
            this.btnText.TabIndex = 0;
            this.btnText.Text = "btnText";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.button1_Click);
            // 
            // displaylbl
            // 
            this.displaylbl.AutoSize = true;
            this.displaylbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displaylbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.displaylbl.Location = new System.Drawing.Point(434, 295);
            this.displaylbl.Name = "displaylbl";
            this.displaylbl.Size = new System.Drawing.Size(53, 22);
            this.displaylbl.TabIndex = 1;
            this.displaylbl.Text = "label1";
            // 
            // clearlbl
            // 
            this.clearlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearlbl.Location = new System.Drawing.Point(195, 58);
            this.clearlbl.Name = "clearlbl";
            this.clearlbl.Size = new System.Drawing.Size(144, 69);
            this.clearlbl.TabIndex = 2;
            this.clearlbl.Text = "btnclearlabel";
            this.clearlbl.UseVisualStyleBackColor = true;
            this.clearlbl.Click += new System.EventHandler(this.button2_Click);
            // 
            // closeform
            // 
            this.closeform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeform.Location = new System.Drawing.Point(356, 58);
            this.closeform.Name = "closeform";
            this.closeform.Size = new System.Drawing.Size(124, 69);
            this.closeform.TabIndex = 3;
            this.closeform.Text = "btnclose";
            this.closeform.UseVisualStyleBackColor = true;
            this.closeform.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeform);
            this.Controls.Add(this.clearlbl);
            this.Controls.Add(this.displaylbl);
            this.Controls.Add(this.btnText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Label displaylbl;
        private System.Windows.Forms.Button clearlbl;
        private System.Windows.Forms.Button closeform;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

