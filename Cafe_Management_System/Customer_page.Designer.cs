namespace Cafe_Management_System
{
    partial class Customer_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_page));
            this.Customer_heading = new System.Windows.Forms.TextBox();
            this.Resturant_Name = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customer_heading
            // 
            this.Customer_heading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Customer_heading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Customer_heading.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_heading.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Customer_heading.Location = new System.Drawing.Point(-9, 36);
            this.Customer_heading.Name = "Customer_heading";
            this.Customer_heading.Size = new System.Drawing.Size(1300, 41);
            this.Customer_heading.TabIndex = 16;
            this.Customer_heading.Text = "Customer";
            this.Customer_heading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Exit.Location = new System.Drawing.Point(87, 500);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(197, 53);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exi&t";
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Blue;
            this.Back.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(87, 329);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(197, 53);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            // 
            // Customer_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.Customer_heading);
            this.Controls.Add(this.Resturant_Name);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Back);
            this.Name = "Customer_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Customer_heading;
        private System.Windows.Forms.TextBox Resturant_Name;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Back;
    }
}