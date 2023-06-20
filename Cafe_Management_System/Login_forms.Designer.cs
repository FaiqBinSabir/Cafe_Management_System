namespace Cafe_Management_System
{
    partial class Login_forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_forms));
            this.Admin_box = new System.Windows.Forms.GroupBox();
            this.Admin_signin = new System.Windows.Forms.Button();
            this.Chef_box = new System.Windows.Forms.GroupBox();
            this.Chef_signin = new System.Windows.Forms.Button();
            this.Customer_box = new System.Windows.Forms.GroupBox();
            this.Customer_signin = new System.Windows.Forms.Button();
            this.Resturant_Name = new System.Windows.Forms.TextBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Admin_box.SuspendLayout();
            this.Chef_box.SuspendLayout();
            this.Customer_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Admin_box
            // 
            this.Admin_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Admin_box.Controls.Add(this.Admin_signin);
            this.Admin_box.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Admin_box.ForeColor = System.Drawing.Color.White;
            this.Admin_box.Location = new System.Drawing.Point(53, 73);
            this.Admin_box.Name = "Admin_box";
            this.Admin_box.Size = new System.Drawing.Size(211, 148);
            this.Admin_box.TabIndex = 0;
            this.Admin_box.TabStop = false;
            this.Admin_box.Text = "Admin";
            // 
            // Admin_signin
            // 
            this.Admin_signin.BackColor = System.Drawing.Color.Green;
            this.Admin_signin.Location = new System.Drawing.Point(39, 64);
            this.Admin_signin.Name = "Admin_signin";
            this.Admin_signin.Size = new System.Drawing.Size(119, 48);
            this.Admin_signin.TabIndex = 0;
            this.Admin_signin.Text = "Sign In";
            this.Admin_signin.UseVisualStyleBackColor = false;
            this.Admin_signin.Click += new System.EventHandler(this.Admin_signin_Click);
            // 
            // Chef_box
            // 
            this.Chef_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Chef_box.Controls.Add(this.Chef_signin);
            this.Chef_box.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Chef_box.ForeColor = System.Drawing.Color.White;
            this.Chef_box.Location = new System.Drawing.Point(961, 73);
            this.Chef_box.Name = "Chef_box";
            this.Chef_box.Size = new System.Drawing.Size(211, 148);
            this.Chef_box.TabIndex = 1;
            this.Chef_box.TabStop = false;
            this.Chef_box.Text = "Chef";
            // 
            // Chef_signin
            // 
            this.Chef_signin.BackColor = System.Drawing.Color.Green;
            this.Chef_signin.Location = new System.Drawing.Point(38, 62);
            this.Chef_signin.Name = "Chef_signin";
            this.Chef_signin.Size = new System.Drawing.Size(119, 48);
            this.Chef_signin.TabIndex = 0;
            this.Chef_signin.Text = "Sign In";
            this.Chef_signin.UseVisualStyleBackColor = false;
            this.Chef_signin.Click += new System.EventHandler(this.Chef_signin_Click);
            // 
            // Customer_box
            // 
            this.Customer_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Customer_box.Controls.Add(this.Customer_signin);
            this.Customer_box.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Customer_box.ForeColor = System.Drawing.Color.White;
            this.Customer_box.Location = new System.Drawing.Point(518, 263);
            this.Customer_box.Name = "Customer_box";
            this.Customer_box.Size = new System.Drawing.Size(211, 148);
            this.Customer_box.TabIndex = 1;
            this.Customer_box.TabStop = false;
            this.Customer_box.Text = "Customer";
            // 
            // Customer_signin
            // 
            this.Customer_signin.BackColor = System.Drawing.Color.Green;
            this.Customer_signin.Location = new System.Drawing.Point(39, 64);
            this.Customer_signin.Name = "Customer_signin";
            this.Customer_signin.Size = new System.Drawing.Size(119, 48);
            this.Customer_signin.TabIndex = 0;
            this.Customer_signin.Text = "Sign In";
            this.Customer_signin.UseVisualStyleBackColor = false;
            this.Customer_signin.Click += new System.EventHandler(this.Customer_signin_Click);
            // 
            // Resturant_Name
            // 
            this.Resturant_Name.BackColor = System.Drawing.SystemColors.Highlight;
            this.Resturant_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Resturant_Name.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resturant_Name.ForeColor = System.Drawing.SystemColors.Window;
            this.Resturant_Name.Location = new System.Drawing.Point(0, 0);
            this.Resturant_Name.Name = "Resturant_Name";
            this.Resturant_Name.Size = new System.Drawing.Size(1300, 29);
            this.Resturant_Name.TabIndex = 9;
            this.Resturant_Name.Text = "Royal Palace Restaurant";
            this.Resturant_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.Blue;
            this.Back_button.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Back_button.ForeColor = System.Drawing.Color.Transparent;
            this.Back_button.Location = new System.Drawing.Point(700, 498);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(128, 45);
            this.Back_button.TabIndex = 10;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Blue;
            this.Exit_button.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Exit_button.ForeColor = System.Drawing.Color.Transparent;
            this.Exit_button.Location = new System.Drawing.Point(415, 498);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(128, 45);
            this.Exit_button.TabIndex = 11;
            this.Exit_button.Text = "Exi&t";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Login_forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Resturant_Name);
            this.Controls.Add(this.Customer_box);
            this.Controls.Add(this.Chef_box);
            this.Controls.Add(this.Admin_box);
            this.Name = "Login_forms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_forms";
            this.Admin_box.ResumeLayout(false);
            this.Chef_box.ResumeLayout(false);
            this.Customer_box.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox Admin_box;
        private System.Windows.Forms.Button Admin_signin;
        public System.Windows.Forms.GroupBox Chef_box;
        private System.Windows.Forms.Button Chef_signin;
        public System.Windows.Forms.GroupBox Customer_box;
        private System.Windows.Forms.Button Customer_signin;
        private System.Windows.Forms.TextBox Resturant_Name;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Exit_button;
    }
}