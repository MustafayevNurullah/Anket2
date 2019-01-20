namespace WindowsFormsApp7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdTXB = new System.Windows.Forms.TextBox();
            this.DogumTXB = new System.Windows.Forms.TextBox();
            this.TelTXB = new System.Windows.Forms.TextBox();
            this.EmailTXB = new System.Windows.Forms.TextBox();
            this.SoyadTXB = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.Label();
            this.Dogum = new System.Windows.Forms.Label();
            this.Soyad = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Ad = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.FileNameTXB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DeyisB = new System.Windows.Forms.Button();
            this.ElaveEtB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ElaveEtB);
            this.groupBox1.Controls.Add(this.DeyisB);
            this.groupBox1.Controls.Add(this.AdTXB);
            this.groupBox1.Controls.Add(this.DogumTXB);
            this.groupBox1.Controls.Add(this.TelTXB);
            this.groupBox1.Controls.Add(this.EmailTXB);
            this.groupBox1.Controls.Add(this.SoyadTXB);
            this.groupBox1.Controls.Add(this.Tel);
            this.groupBox1.Controls.Add(this.Dogum);
            this.groupBox1.Controls.Add(this.Soyad);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.Ad);
            this.groupBox1.Location = new System.Drawing.Point(35, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anket";
            // 
            // AdTXB
            // 
            this.AdTXB.Location = new System.Drawing.Point(99, 29);
            this.AdTXB.Name = "AdTXB";
            this.AdTXB.Size = new System.Drawing.Size(100, 20);
            this.AdTXB.TabIndex = 1;
            // 
            // DogumTXB
            // 
            this.DogumTXB.Location = new System.Drawing.Point(99, 148);
            this.DogumTXB.Name = "DogumTXB";
            this.DogumTXB.Size = new System.Drawing.Size(100, 20);
            this.DogumTXB.TabIndex = 1;
            // 
            // TelTXB
            // 
            this.TelTXB.Location = new System.Drawing.Point(99, 122);
            this.TelTXB.Name = "TelTXB";
            this.TelTXB.Size = new System.Drawing.Size(100, 20);
            this.TelTXB.TabIndex = 1;
            // 
            // EmailTXB
            // 
            this.EmailTXB.Location = new System.Drawing.Point(99, 92);
            this.EmailTXB.Name = "EmailTXB";
            this.EmailTXB.Size = new System.Drawing.Size(100, 20);
            this.EmailTXB.TabIndex = 1;
            // 
            // SoyadTXB
            // 
            this.SoyadTXB.Location = new System.Drawing.Point(99, 63);
            this.SoyadTXB.Name = "SoyadTXB";
            this.SoyadTXB.Size = new System.Drawing.Size(100, 20);
            this.SoyadTXB.TabIndex = 1;
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.Location = new System.Drawing.Point(7, 122);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(22, 13);
            this.Tel.TabIndex = 0;
            this.Tel.Text = "Tel";
            // 
            // Dogum
            // 
            this.Dogum.AutoSize = true;
            this.Dogum.Location = new System.Drawing.Point(7, 151);
            this.Dogum.Name = "Dogum";
            this.Dogum.Size = new System.Drawing.Size(41, 13);
            this.Dogum.TabIndex = 0;
            this.Dogum.Text = "Dogum";
            // 
            // Soyad
            // 
            this.Soyad.AutoSize = true;
            this.Soyad.Location = new System.Drawing.Point(6, 63);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(37, 13);
            this.Soyad.TabIndex = 0;
            this.Soyad.Text = "Soyad";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(6, 92);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email";
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Location = new System.Drawing.Point(7, 29);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(20, 13);
            this.Ad.TabIndex = 0;
            this.Ad.Text = "Ad";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(577, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 212);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FileNameTXB
            // 
            this.FileNameTXB.Location = new System.Drawing.Point(577, 269);
            this.FileNameTXB.Name = "FileNameTXB";
            this.FileNameTXB.Size = new System.Drawing.Size(194, 20);
            this.FileNameTXB.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeyisB
            // 
            this.DeyisB.Location = new System.Drawing.Point(303, 220);
            this.DeyisB.Name = "DeyisB";
            this.DeyisB.Size = new System.Drawing.Size(75, 23);
            this.DeyisB.TabIndex = 3;
            this.DeyisB.Text = "Deyis";
            this.DeyisB.UseVisualStyleBackColor = true;
            this.DeyisB.Click += new System.EventHandler(this.DeyisB_Click);
            // 
            // ElaveEtB
            // 
            this.ElaveEtB.Location = new System.Drawing.Point(303, 257);
            this.ElaveEtB.Name = "ElaveEtB";
            this.ElaveEtB.Size = new System.Drawing.Size(75, 23);
            this.ElaveEtB.TabIndex = 4;
            this.ElaveEtB.Text = "Elave Et";
            this.ElaveEtB.UseVisualStyleBackColor = true;
            this.ElaveEtB.Click += new System.EventHandler(this.ElaveEtB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FileNameTXB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AdTXB;
        private System.Windows.Forms.TextBox DogumTXB;
        private System.Windows.Forms.TextBox TelTXB;
        private System.Windows.Forms.TextBox EmailTXB;
        private System.Windows.Forms.TextBox SoyadTXB;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.Label Dogum;
        private System.Windows.Forms.Label Soyad;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox FileNameTXB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ElaveEtB;
        private System.Windows.Forms.Button DeyisB;
    }
}

