namespace Cafe_Management_System
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Resturant_Name = new System.Windows.Forms.TextBox();
            this.Go_To_System = new System.Windows.Forms.Button();
            this.location_link = new System.Windows.Forms.LinkLabel();
            this.About_us = new System.Windows.Forms.GroupBox();
            this.Instagram_link = new System.Windows.Forms.LinkLabel();
            this.Whatsapp_link = new System.Windows.Forms.LinkLabel();
            this.Facebook_link = new System.Windows.Forms.LinkLabel();
            this.About_us.SuspendLayout();
            this.SuspendLayout();
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
            this.Resturant_Name.TabIndex = 8;
            this.Resturant_Name.Text = "Royal Palace Restaurant";
            this.Resturant_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Go_To_System
            // 
            this.Go_To_System.BackColor = System.Drawing.Color.Chocolate;
            this.Go_To_System.FlatAppearance.BorderSize = 2;
            this.Go_To_System.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Go_To_System.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Go_To_System.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go_To_System.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Go_To_System.Location = new System.Drawing.Point(870, 105);
            this.Go_To_System.Name = "Go_To_System";
            this.Go_To_System.Size = new System.Drawing.Size(260, 131);
            this.Go_To_System.TabIndex = 1;
            this.Go_To_System.Text = "GO TO RESTAURANT SYSTEM";
            this.Go_To_System.UseVisualStyleBackColor = false;
            this.Go_To_System.Click += new System.EventHandler(this.Go_To_System_Click);
            // 
            // location_link
            // 
            this.location_link.AutoSize = true;
            this.location_link.LinkColor = System.Drawing.Color.Red;
            this.location_link.Location = new System.Drawing.Point(14, 212);
            this.location_link.Name = "location_link";
            this.location_link.Size = new System.Drawing.Size(208, 35);
            this.location_link.TabIndex = 3;
            this.location_link.TabStop = true;
            this.location_link.Text = " --> Our Location";
            this.location_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.location_link_LinkClicked);
            // 
            // About_us
            // 
            this.About_us.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("About_us.BackgroundImage")));
            this.About_us.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.About_us.Controls.Add(this.Instagram_link);
            this.About_us.Controls.Add(this.Whatsapp_link);
            this.About_us.Controls.Add(this.Facebook_link);
            this.About_us.Controls.Add(this.location_link);
            this.About_us.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_us.ForeColor = System.Drawing.Color.Yellow;
            this.About_us.Location = new System.Drawing.Point(616, 306);
            this.About_us.Name = "About_us";
            this.About_us.Size = new System.Drawing.Size(499, 297);
            this.About_us.TabIndex = 2;
            this.About_us.TabStop = false;
            this.About_us.Text = "More About Us";
            // 
            // Instagram_link
            // 
            this.Instagram_link.AutoSize = true;
            this.Instagram_link.LinkColor = System.Drawing.Color.Red;
            this.Instagram_link.Location = new System.Drawing.Point(14, 48);
            this.Instagram_link.Name = "Instagram_link";
            this.Instagram_link.Size = new System.Drawing.Size(222, 35);
            this.Instagram_link.TabIndex = 6;
            this.Instagram_link.TabStop = true;
            this.Instagram_link.Text = " -->Instagram Link";
            this.Instagram_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Instagram_link_LinkClicked);
            // 
            // Whatsapp_link
            // 
            this.Whatsapp_link.AutoSize = true;
            this.Whatsapp_link.LinkColor = System.Drawing.Color.Red;
            this.Whatsapp_link.Location = new System.Drawing.Point(14, 104);
            this.Whatsapp_link.Name = "Whatsapp_link";
            this.Whatsapp_link.Size = new System.Drawing.Size(225, 35);
            this.Whatsapp_link.TabIndex = 5;
            this.Whatsapp_link.TabStop = true;
            this.Whatsapp_link.Text = " -->Whatsapp Link";
            this.Whatsapp_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Whatsapp_link_LinkClicked);
            // 
            // Facebook_link
            // 
            this.Facebook_link.AutoSize = true;
            this.Facebook_link.LinkColor = System.Drawing.Color.Red;
            this.Facebook_link.Location = new System.Drawing.Point(14, 157);
            this.Facebook_link.Name = "Facebook_link";
            this.Facebook_link.Size = new System.Drawing.Size(222, 35);
            this.Facebook_link.TabIndex = 4;
            this.Facebook_link.TabStop = true;
            this.Facebook_link.Text = " --> Facebook Link";
            this.Facebook_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Facebook_link_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.About_us);
            this.Controls.Add(this.Go_To_System);
            this.Controls.Add(this.Resturant_Name);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.About_us.ResumeLayout(false);
            this.About_us.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox Resturant_Name;
        private System.Windows.Forms.Button Go_To_System;
        private System.Windows.Forms.LinkLabel location_link;
        private System.Windows.Forms.GroupBox About_us;
        private System.Windows.Forms.LinkLabel Instagram_link;
        private System.Windows.Forms.LinkLabel Whatsapp_link;
        private System.Windows.Forms.LinkLabel Facebook_link;
    }
}

