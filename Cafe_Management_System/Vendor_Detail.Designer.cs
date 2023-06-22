namespace Cafe_Management_System
{
    partial class Vendor_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendor_Detail));
            this.Exit = new System.Windows.Forms.Button();
            this.Vendor_address = new System.Windows.Forms.Label();
            this.Vendor_name_input = new System.Windows.Forms.TextBox();
            this.Vendor_Name = new System.Windows.Forms.Label();
            this.Vendor_id_input = new System.Windows.Forms.TextBox();
            this.Vendor_id = new System.Windows.Forms.Label();
            this.Insert_Vendor = new System.Windows.Forms.Button();
            this.Vendor_number_input = new System.Windows.Forms.TextBox();
            this.Delete_Vendor = new System.Windows.Forms.Button();
            this.Update_Vendor = new System.Windows.Forms.Button();
            this.View_Vendor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Admin__id = new System.Windows.Forms.Label();
            this.Admin_id_inputt = new System.Windows.Forms.TextBox();
            this.Vendor_address_input = new System.Windows.Forms.TextBox();
            this.Vendor_CRUD_box = new System.Windows.Forms.GroupBox();
            this.Vendor_number = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Vendor_CRUD_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Exit.FlatAppearance.BorderSize = 2;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(1041, 588);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(213, 53);
            this.Exit.TabIndex = 39;
            this.Exit.Text = "Exi&t";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Vendor_address
            // 
            this.Vendor_address.AutoSize = true;
            this.Vendor_address.Location = new System.Drawing.Point(16, 236);
            this.Vendor_address.Name = "Vendor_address";
            this.Vendor_address.Size = new System.Drawing.Size(116, 35);
            this.Vendor_address.TabIndex = 5;
            this.Vendor_address.Text = "Address:";
            // 
            // Vendor_name_input
            // 
            this.Vendor_name_input.Location = new System.Drawing.Point(185, 114);
            this.Vendor_name_input.Name = "Vendor_name_input";
            this.Vendor_name_input.Size = new System.Drawing.Size(260, 40);
            this.Vendor_name_input.TabIndex = 2;
            // 
            // Vendor_Name
            // 
            this.Vendor_Name.AutoSize = true;
            this.Vendor_Name.Location = new System.Drawing.Point(16, 117);
            this.Vendor_Name.Name = "Vendor_Name";
            this.Vendor_Name.Size = new System.Drawing.Size(92, 35);
            this.Vendor_Name.TabIndex = 2;
            this.Vendor_Name.Text = "Name:";
            // 
            // Vendor_id_input
            // 
            this.Vendor_id_input.Location = new System.Drawing.Point(185, 52);
            this.Vendor_id_input.Name = "Vendor_id_input";
            this.Vendor_id_input.Size = new System.Drawing.Size(259, 40);
            this.Vendor_id_input.TabIndex = 1;
            // 
            // Vendor_id
            // 
            this.Vendor_id.AutoSize = true;
            this.Vendor_id.Location = new System.Drawing.Point(16, 57);
            this.Vendor_id.Name = "Vendor_id";
            this.Vendor_id.Size = new System.Drawing.Size(48, 35);
            this.Vendor_id.TabIndex = 0;
            this.Vendor_id.Text = "ID:";
            this.Vendor_id.Click += new System.EventHandler(this.Vendor_id_Click);
            // 
            // Insert_Vendor
            // 
            this.Insert_Vendor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Insert_Vendor.FlatAppearance.BorderSize = 2;
            this.Insert_Vendor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.Insert_Vendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_Vendor.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Insert_Vendor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Insert_Vendor.Location = new System.Drawing.Point(44, 196);
            this.Insert_Vendor.Name = "Insert_Vendor";
            this.Insert_Vendor.Size = new System.Drawing.Size(213, 53);
            this.Insert_Vendor.TabIndex = 44;
            this.Insert_Vendor.Text = "Insert Vendor";
            this.Insert_Vendor.UseVisualStyleBackColor = false;
            this.Insert_Vendor.Click += new System.EventHandler(this.Insert_Vendor_Click);
            // 
            // Vendor_number_input
            // 
            this.Vendor_number_input.Location = new System.Drawing.Point(186, 172);
            this.Vendor_number_input.Name = "Vendor_number_input";
            this.Vendor_number_input.Size = new System.Drawing.Size(260, 40);
            this.Vendor_number_input.TabIndex = 7;
            this.Vendor_number_input.TextChanged += new System.EventHandler(this.Vendor_number_input_TextChanged);
            // 
            // Delete_Vendor
            // 
            this.Delete_Vendor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Delete_Vendor.FlatAppearance.BorderSize = 2;
            this.Delete_Vendor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.Delete_Vendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Vendor.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Delete_Vendor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_Vendor.Location = new System.Drawing.Point(44, 273);
            this.Delete_Vendor.Name = "Delete_Vendor";
            this.Delete_Vendor.Size = new System.Drawing.Size(213, 53);
            this.Delete_Vendor.TabIndex = 43;
            this.Delete_Vendor.Text = "Delete Vendor";
            this.Delete_Vendor.UseVisualStyleBackColor = false;
            this.Delete_Vendor.Click += new System.EventHandler(this.Delete_Vendor_Click);
            // 
            // Update_Vendor
            // 
            this.Update_Vendor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Update_Vendor.FlatAppearance.BorderSize = 2;
            this.Update_Vendor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.Update_Vendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Vendor.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Update_Vendor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update_Vendor.Location = new System.Drawing.Point(44, 349);
            this.Update_Vendor.Name = "Update_Vendor";
            this.Update_Vendor.Size = new System.Drawing.Size(213, 53);
            this.Update_Vendor.TabIndex = 42;
            this.Update_Vendor.Text = "Update Vendor";
            this.Update_Vendor.UseVisualStyleBackColor = false;
            this.Update_Vendor.Click += new System.EventHandler(this.Update_Vendor_Click);
            // 
            // View_Vendor
            // 
            this.View_Vendor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.View_Vendor.FlatAppearance.BorderSize = 2;
            this.View_Vendor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.View_Vendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Vendor.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.View_Vendor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.View_Vendor.Location = new System.Drawing.Point(44, 119);
            this.View_Vendor.Name = "View_Vendor";
            this.View_Vendor.Size = new System.Drawing.Size(213, 53);
            this.View_Vendor.TabIndex = 41;
            this.View_Vendor.Text = "View Vendor&s";
            this.View_Vendor.UseVisualStyleBackColor = false;
            this.View_Vendor.Click += new System.EventHandler(this.View_Vendor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(783, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(439, 505);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Admin__id
            // 
            this.Admin__id.AutoSize = true;
            this.Admin__id.Location = new System.Drawing.Point(16, 300);
            this.Admin__id.Name = "Admin__id";
            this.Admin__id.Size = new System.Drawing.Size(131, 35);
            this.Admin__id.TabIndex = 10;
            this.Admin__id.Text = "Admin ID:";
            // 
            // Admin_id_inputt
            // 
            this.Admin_id_inputt.Location = new System.Drawing.Point(186, 297);
            this.Admin_id_inputt.Name = "Admin_id_inputt";
            this.Admin_id_inputt.Size = new System.Drawing.Size(259, 40);
            this.Admin_id_inputt.TabIndex = 9;
            // 
            // Vendor_address_input
            // 
            this.Vendor_address_input.Location = new System.Drawing.Point(185, 231);
            this.Vendor_address_input.Name = "Vendor_address_input";
            this.Vendor_address_input.Size = new System.Drawing.Size(260, 40);
            this.Vendor_address_input.TabIndex = 8;
            // 
            // Vendor_CRUD_box
            // 
            this.Vendor_CRUD_box.BackColor = System.Drawing.Color.Transparent;
            this.Vendor_CRUD_box.Controls.Add(this.Admin__id);
            this.Vendor_CRUD_box.Controls.Add(this.Admin_id_inputt);
            this.Vendor_CRUD_box.Controls.Add(this.Vendor_address_input);
            this.Vendor_CRUD_box.Controls.Add(this.Vendor_number_input);
            this.Vendor_CRUD_box.Controls.Add(this.Vendor_number);
            this.Vendor_CRUD_box.Controls.Add(this.Vendor_address);
            this.Vendor_CRUD_box.Controls.Add(this.Vendor_name_input);
            this.Vendor_CRUD_box.Controls.Add(this.Vendor_Name);
            this.Vendor_CRUD_box.Controls.Add(this.Vendor_id_input);
            this.Vendor_CRUD_box.Controls.Add(this.Vendor_id);
            this.Vendor_CRUD_box.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Vendor_CRUD_box.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Vendor_CRUD_box.Location = new System.Drawing.Point(275, 81);
            this.Vendor_CRUD_box.Name = "Vendor_CRUD_box";
            this.Vendor_CRUD_box.Size = new System.Drawing.Size(479, 391);
            this.Vendor_CRUD_box.TabIndex = 46;
            this.Vendor_CRUD_box.TabStop = false;
            this.Vendor_CRUD_box.Text = "Vendor";
            this.Vendor_CRUD_box.Enter += new System.EventHandler(this.Vendor_CRUD_box_Enter);
            // 
            // Vendor_number
            // 
            this.Vendor_number.AutoSize = true;
            this.Vendor_number.Location = new System.Drawing.Point(16, 177);
            this.Vendor_number.Name = "Vendor_number";
            this.Vendor_number.Size = new System.Drawing.Size(118, 35);
            this.Vendor_number.TabIndex = 6;
            this.Vendor_number.Text = "Number:";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Back.FlatAppearance.BorderSize = 2;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(28, 588);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(213, 53);
            this.Back.TabIndex = 40;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Vendor_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Insert_Vendor);
            this.Controls.Add(this.Delete_Vendor);
            this.Controls.Add(this.Update_Vendor);
            this.Controls.Add(this.View_Vendor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Vendor_CRUD_box);
            this.Controls.Add(this.Back);
            this.Name = "Vendor_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor_Detail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Vendor_CRUD_box.ResumeLayout(false);
            this.Vendor_CRUD_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Vendor_address;
        private System.Windows.Forms.TextBox Vendor_name_input;
        private System.Windows.Forms.Label Vendor_Name;
        private System.Windows.Forms.TextBox Vendor_id_input;
        private System.Windows.Forms.Label Vendor_id;
        private System.Windows.Forms.Button Insert_Vendor;
        private System.Windows.Forms.TextBox Vendor_number_input;
        private System.Windows.Forms.Button Delete_Vendor;
        private System.Windows.Forms.Button Update_Vendor;
        private System.Windows.Forms.Button View_Vendor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Admin__id;
        private System.Windows.Forms.TextBox Admin_id_inputt;
        private System.Windows.Forms.TextBox Vendor_address_input;
        private System.Windows.Forms.GroupBox Vendor_CRUD_box;
        private System.Windows.Forms.Label Vendor_number;
        private System.Windows.Forms.Button Back;
    }
}