namespace Cafe_Management_System
{
    partial class Supplier_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier_Detail));
            this.Exit = new System.Windows.Forms.Button();
            this.Admin__id = new System.Windows.Forms.Label();
            this.Admin_id_inputt = new System.Windows.Forms.TextBox();
            this.product_id_input = new System.Windows.Forms.TextBox();
            this.Supplier_number_input = new System.Windows.Forms.TextBox();
            this.Supplier_number = new System.Windows.Forms.Label();
            this.product_quantity = new System.Windows.Forms.Label();
            this.Supplier_name_input = new System.Windows.Forms.TextBox();
            this.Insert_Supplier = new System.Windows.Forms.Button();
            this.Delete_Supplier = new System.Windows.Forms.Button();
            this.Update_Supplier = new System.Windows.Forms.Button();
            this.View_Supplier = new System.Windows.Forms.Button();
            this.Supplier_Name = new System.Windows.Forms.Label();
            this.Supplier_id_input = new System.Windows.Forms.TextBox();
            this.Supplier_id = new System.Windows.Forms.Label();
            this.Supplier_CRUD_box = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Supplier_CRUD_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.Exit.Location = new System.Drawing.Point(1025, 575);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(213, 53);
            this.Exit.TabIndex = 31;
            this.Exit.Text = "Exi&t";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Admin__id
            // 
            this.Admin__id.AutoSize = true;
            this.Admin__id.Location = new System.Drawing.Point(14, 287);
            this.Admin__id.Name = "Admin__id";
            this.Admin__id.Size = new System.Drawing.Size(131, 35);
            this.Admin__id.TabIndex = 10;
            this.Admin__id.Text = "Admin ID:";
            // 
            // Admin_id_inputt
            // 
            this.Admin_id_inputt.Location = new System.Drawing.Point(196, 287);
            this.Admin_id_inputt.Name = "Admin_id_inputt";
            this.Admin_id_inputt.Size = new System.Drawing.Size(248, 40);
            this.Admin_id_inputt.TabIndex = 9;
            // 
            // product_id_input
            // 
            this.product_id_input.Location = new System.Drawing.Point(196, 228);
            this.product_id_input.Name = "product_id_input";
            this.product_id_input.Size = new System.Drawing.Size(249, 40);
            this.product_id_input.TabIndex = 8;
            this.product_id_input.TextChanged += new System.EventHandler(this.product_id_input_TextChanged);
            // 
            // Supplier_number_input
            // 
            this.Supplier_number_input.Location = new System.Drawing.Point(196, 167);
            this.Supplier_number_input.Name = "Supplier_number_input";
            this.Supplier_number_input.Size = new System.Drawing.Size(249, 40);
            this.Supplier_number_input.TabIndex = 7;
            this.Supplier_number_input.TextChanged += new System.EventHandler(this.Supplier_number_input_TextChanged);
            // 
            // Supplier_number
            // 
            this.Supplier_number.AutoSize = true;
            this.Supplier_number.Location = new System.Drawing.Point(27, 172);
            this.Supplier_number.Name = "Supplier_number";
            this.Supplier_number.Size = new System.Drawing.Size(118, 35);
            this.Supplier_number.TabIndex = 6;
            this.Supplier_number.Text = "Number:";
            // 
            // product_quantity
            // 
            this.product_quantity.AutoSize = true;
            this.product_quantity.Location = new System.Drawing.Point(27, 228);
            this.product_quantity.Name = "product_quantity";
            this.product_quantity.Size = new System.Drawing.Size(115, 35);
            this.product_quantity.TabIndex = 5;
            this.product_quantity.Text = "Product:";
            // 
            // Supplier_name_input
            // 
            this.Supplier_name_input.Location = new System.Drawing.Point(196, 109);
            this.Supplier_name_input.Name = "Supplier_name_input";
            this.Supplier_name_input.Size = new System.Drawing.Size(249, 40);
            this.Supplier_name_input.TabIndex = 2;
            // 
            // Insert_Supplier
            // 
            this.Insert_Supplier.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Insert_Supplier.FlatAppearance.BorderSize = 2;
            this.Insert_Supplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.Insert_Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_Supplier.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Insert_Supplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Insert_Supplier.Location = new System.Drawing.Point(44, 165);
            this.Insert_Supplier.Name = "Insert_Supplier";
            this.Insert_Supplier.Size = new System.Drawing.Size(213, 53);
            this.Insert_Supplier.TabIndex = 36;
            this.Insert_Supplier.Text = "Insert Supplier";
            this.Insert_Supplier.UseVisualStyleBackColor = false;
            this.Insert_Supplier.Click += new System.EventHandler(this.Insert_Supplier_Click);
            // 
            // Delete_Supplier
            // 
            this.Delete_Supplier.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Delete_Supplier.FlatAppearance.BorderSize = 2;
            this.Delete_Supplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.Delete_Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Supplier.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Delete_Supplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_Supplier.Location = new System.Drawing.Point(44, 241);
            this.Delete_Supplier.Name = "Delete_Supplier";
            this.Delete_Supplier.Size = new System.Drawing.Size(213, 53);
            this.Delete_Supplier.TabIndex = 35;
            this.Delete_Supplier.Text = "Delete Supplier";
            this.Delete_Supplier.UseVisualStyleBackColor = false;
            this.Delete_Supplier.Click += new System.EventHandler(this.Delete_Supplier_Click);
            // 
            // Update_Supplier
            // 
            this.Update_Supplier.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Update_Supplier.FlatAppearance.BorderSize = 2;
            this.Update_Supplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.Update_Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Supplier.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Update_Supplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update_Supplier.Location = new System.Drawing.Point(44, 334);
            this.Update_Supplier.Name = "Update_Supplier";
            this.Update_Supplier.Size = new System.Drawing.Size(225, 53);
            this.Update_Supplier.TabIndex = 34;
            this.Update_Supplier.Text = "Update Supplier";
            this.Update_Supplier.UseVisualStyleBackColor = false;
            this.Update_Supplier.Click += new System.EventHandler(this.Update_Supplier_Click);
            // 
            // View_Supplier
            // 
            this.View_Supplier.BackColor = System.Drawing.Color.DarkSlateGray;
            this.View_Supplier.FlatAppearance.BorderSize = 2;
            this.View_Supplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.View_Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Supplier.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.View_Supplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.View_Supplier.Location = new System.Drawing.Point(44, 82);
            this.View_Supplier.Name = "View_Supplier";
            this.View_Supplier.Size = new System.Drawing.Size(213, 53);
            this.View_Supplier.TabIndex = 33;
            this.View_Supplier.Text = "View Supplier&s";
            this.View_Supplier.UseVisualStyleBackColor = false;
            this.View_Supplier.Click += new System.EventHandler(this.View_Supplier_Click);
            // 
            // Supplier_Name
            // 
            this.Supplier_Name.AutoSize = true;
            this.Supplier_Name.Location = new System.Drawing.Point(43, 114);
            this.Supplier_Name.Name = "Supplier_Name";
            this.Supplier_Name.Size = new System.Drawing.Size(92, 35);
            this.Supplier_Name.TabIndex = 2;
            this.Supplier_Name.Text = "Name:";
            // 
            // Supplier_id_input
            // 
            this.Supplier_id_input.Location = new System.Drawing.Point(196, 52);
            this.Supplier_id_input.Name = "Supplier_id_input";
            this.Supplier_id_input.Size = new System.Drawing.Size(249, 40);
            this.Supplier_id_input.TabIndex = 1;
            // 
            // Supplier_id
            // 
            this.Supplier_id.AutoSize = true;
            this.Supplier_id.Location = new System.Drawing.Point(62, 57);
            this.Supplier_id.Name = "Supplier_id";
            this.Supplier_id.Size = new System.Drawing.Size(48, 35);
            this.Supplier_id.TabIndex = 0;
            this.Supplier_id.Text = "ID:";
            // 
            // Supplier_CRUD_box
            // 
            this.Supplier_CRUD_box.BackColor = System.Drawing.Color.Transparent;
            this.Supplier_CRUD_box.Controls.Add(this.Admin__id);
            this.Supplier_CRUD_box.Controls.Add(this.Admin_id_inputt);
            this.Supplier_CRUD_box.Controls.Add(this.product_id_input);
            this.Supplier_CRUD_box.Controls.Add(this.Supplier_number_input);
            this.Supplier_CRUD_box.Controls.Add(this.Supplier_number);
            this.Supplier_CRUD_box.Controls.Add(this.product_quantity);
            this.Supplier_CRUD_box.Controls.Add(this.Supplier_name_input);
            this.Supplier_CRUD_box.Controls.Add(this.Supplier_Name);
            this.Supplier_CRUD_box.Controls.Add(this.Supplier_id_input);
            this.Supplier_CRUD_box.Controls.Add(this.Supplier_id);
            this.Supplier_CRUD_box.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Supplier_CRUD_box.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Supplier_CRUD_box.Location = new System.Drawing.Point(275, 82);
            this.Supplier_CRUD_box.Name = "Supplier_CRUD_box";
            this.Supplier_CRUD_box.Size = new System.Drawing.Size(479, 365);
            this.Supplier_CRUD_box.TabIndex = 38;
            this.Supplier_CRUD_box.TabStop = false;
            this.Supplier_CRUD_box.Text = "Supplier";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(799, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(439, 390);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Back.FlatAppearance.BorderSize = 2;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(12, 575);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(213, 53);
            this.Back.TabIndex = 32;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Supplier_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Insert_Supplier);
            this.Controls.Add(this.Delete_Supplier);
            this.Controls.Add(this.Update_Supplier);
            this.Controls.Add(this.View_Supplier);
            this.Controls.Add(this.Supplier_CRUD_box);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.DoubleBuffered = true;
            this.Name = "Supplier_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier_Detail";
            this.Supplier_CRUD_box.ResumeLayout(false);
            this.Supplier_CRUD_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Admin__id;
        private System.Windows.Forms.TextBox Admin_id_inputt;
        private System.Windows.Forms.TextBox product_id_input;
        private System.Windows.Forms.TextBox Supplier_number_input;
        private System.Windows.Forms.Label Supplier_number;
        private System.Windows.Forms.Label product_quantity;
        private System.Windows.Forms.TextBox Supplier_name_input;
        private System.Windows.Forms.Button Insert_Supplier;
        private System.Windows.Forms.Button Delete_Supplier;
        private System.Windows.Forms.Button Update_Supplier;
        private System.Windows.Forms.Button View_Supplier;
        private System.Windows.Forms.Label Supplier_Name;
        private System.Windows.Forms.TextBox Supplier_id_input;
        private System.Windows.Forms.Label Supplier_id;
        private System.Windows.Forms.GroupBox Supplier_CRUD_box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back;
    }
}