namespace Cafe_Management_System
{
    partial class Admin_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_page));
            this.Admin_signin_box = new System.Windows.Forms.GroupBox();
            this.Admin_signin = new System.Windows.Forms.Button();
            this.Admin_password_input = new System.Windows.Forms.TextBox();
            this.Admin_password = new System.Windows.Forms.Label();
            this.Admin_id_input = new System.Windows.Forms.TextBox();
            this.Admin_id = new System.Windows.Forms.Label();
            this.Admin_heading = new System.Windows.Forms.TextBox();
            this.Resturant_Name = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Admin_signin_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Admin_signin_box
            // 
            this.Admin_signin_box.BackColor = System.Drawing.Color.Transparent;
            this.Admin_signin_box.Controls.Add(this.Admin_signin);
            this.Admin_signin_box.Controls.Add(this.Admin_password_input);
            this.Admin_signin_box.Controls.Add(this.Admin_password);
            this.Admin_signin_box.Controls.Add(this.Admin_id_input);
            this.Admin_signin_box.Controls.Add(this.Admin_id);
            this.Admin_signin_box.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Admin_signin_box.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Admin_signin_box.Location = new System.Drawing.Point(416, 155);
            this.Admin_signin_box.Name = "Admin_signin_box";
            this.Admin_signin_box.Size = new System.Drawing.Size(474, 404);
            this.Admin_signin_box.TabIndex = 17;
            this.Admin_signin_box.TabStop = false;
            this.Admin_signin_box.Text = "Admin Signin";
            // 
            // Admin_signin
            // 
            this.Admin_signin.BackColor = System.Drawing.Color.Blue;
            this.Admin_signin.Location = new System.Drawing.Point(105, 315);
            this.Admin_signin.Name = "Admin_signin";
            this.Admin_signin.Size = new System.Drawing.Size(220, 53);
            this.Admin_signin.TabIndex = 3;
            this.Admin_signin.Text = "Sign In";
            this.Admin_signin.UseVisualStyleBackColor = false;
            this.Admin_signin.Click += new System.EventHandler(this.Admin_signin_Click);
            // 
            // Admin_password_input
            // 
            this.Admin_password_input.Location = new System.Drawing.Point(49, 240);
            this.Admin_password_input.Name = "Admin_password_input";
            this.Admin_password_input.Size = new System.Drawing.Size(276, 40);
            this.Admin_password_input.TabIndex = 2;
            // 
            // Admin_password
            // 
            this.Admin_password.AutoSize = true;
            this.Admin_password.Location = new System.Drawing.Point(35, 185);
            this.Admin_password.Name = "Admin_password";
            this.Admin_password.Size = new System.Drawing.Size(126, 35);
            this.Admin_password.TabIndex = 2;
            this.Admin_password.Text = "Password";
            // 
            // Admin_id_input
            // 
            this.Admin_id_input.Location = new System.Drawing.Point(48, 99);
            this.Admin_id_input.Name = "Admin_id_input";
            this.Admin_id_input.Size = new System.Drawing.Size(277, 40);
            this.Admin_id_input.TabIndex = 1;
            // 
            // Admin_id
            // 
            this.Admin_id.AutoSize = true;
            this.Admin_id.Location = new System.Drawing.Point(35, 52);
            this.Admin_id.Name = "Admin_id";
            this.Admin_id.Size = new System.Drawing.Size(46, 35);
            this.Admin_id.TabIndex = 0;
            this.Admin_id.Text = "ID ";
            // 
            // Admin_heading
            // 
            this.Admin_heading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Admin_heading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Admin_heading.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_heading.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Admin_heading.Location = new System.Drawing.Point(0, 30);
            this.Admin_heading.Name = "Admin_heading";
            this.Admin_heading.Size = new System.Drawing.Size(1300, 41);
            this.Admin_heading.TabIndex = 16;
            this.Admin_heading.Text = "Admin";
            this.Admin_heading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Resturant_Name.TabIndex = 15;
            this.Resturant_Name.Text = "Royal Palace Restaurant";
            this.Resturant_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Blue;
            this.Exit.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(64, 459);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(197, 53);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exi&t";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Blue;
            this.Back.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(64, 306);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(197, 53);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.Admin_signin_box);
            this.Controls.Add(this.Admin_heading);
            this.Controls.Add(this.Resturant_Name);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Back);
            this.Name = "Admin_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_page";
            this.Admin_signin_box.ResumeLayout(false);
            this.Admin_signin_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Admin_signin_box;
        private System.Windows.Forms.Button Admin_signin;
        private System.Windows.Forms.TextBox Admin_password_input;
        private System.Windows.Forms.Label Admin_password;
        private System.Windows.Forms.TextBox Admin_id_input;
        private System.Windows.Forms.Label Admin_id;
        private System.Windows.Forms.TextBox Admin_heading;
        private System.Windows.Forms.TextBox Resturant_Name;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Back;
    }
}