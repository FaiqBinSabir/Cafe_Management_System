namespace Cafe_Management_System
{
    partial class Product_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Detail));
            this.Product_CRUD_box = new System.Windows.Forms.GroupBox();
            this.Admin__id = new System.Windows.Forms.Label();
            this.Admin_id_inputt = new System.Windows.Forms.TextBox();
            this.product_quan_input = new System.Windows.Forms.TextBox();
            this.Vendor_id_input = new System.Windows.Forms.TextBox();
            this.Vendor_id = new System.Windows.Forms.Label();
            this.product_quantity = new System.Windows.Forms.Label();
            this.Product_name_input = new System.Windows.Forms.TextBox();
            this.Food_Name = new System.Windows.Forms.Label();
            this.Product_id_input = new System.Windows.Forms.TextBox();
            this.Food_id = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insert_Product = new System.Windows.Forms.Button();
            this.Delete_Product = new System.Windows.Forms.Button();
            this.Update_Product = new System.Windows.Forms.Button();
            this.View_Product = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Product_CRUD_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Product_CRUD_box
            // 
            this.Product_CRUD_box.BackColor = System.Drawing.Color.Transparent;
            this.Product_CRUD_box.Controls.Add(this.Admin__id);
            this.Product_CRUD_box.Controls.Add(this.Admin_id_inputt);
            this.Product_CRUD_box.Controls.Add(this.product_quan_input);
            this.Product_CRUD_box.Controls.Add(this.Vendor_id_input);
            this.Product_CRUD_box.Controls.Add(this.Vendor_id);
            this.Product_CRUD_box.Controls.Add(this.product_quantity);
            this.Product_CRUD_box.Controls.Add(this.Product_name_input);
            this.Product_CRUD_box.Controls.Add(this.Food_Name);
            this.Product_CRUD_box.Controls.Add(this.Product_id_input);
            this.Product_CRUD_box.Controls.Add(this.Food_id);
            this.Product_CRUD_box.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Product_CRUD_box.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Product_CRUD_box.Location = new System.Drawing.Point(267, 82);
            this.Product_CRUD_box.Name = "Product_CRUD_box";
            this.Product_CRUD_box.Size = new System.Drawing.Size(479, 355);
            this.Product_CRUD_box.TabIndex = 30;
            this.Product_CRUD_box.TabStop = false;
            this.Product_CRUD_box.Text = "Product";
            // 
            // Admin__id
            // 
            this.Admin__id.AutoSize = true;
            this.Admin__id.Location = new System.Drawing.Point(16, 302);
            this.Admin__id.Name = "Admin__id";
            this.Admin__id.Size = new System.Drawing.Size(131, 35);
            this.Admin__id.TabIndex = 10;
            this.Admin__id.Text = "Admin ID:";
            // 
            // Admin_id_inputt
            // 
            this.Admin_id_inputt.Location = new System.Drawing.Point(168, 302);
            this.Admin_id_inputt.Name = "Admin_id_inputt";
            this.Admin_id_inputt.Size = new System.Drawing.Size(276, 40);
            this.Admin_id_inputt.TabIndex = 9;
            // 
            // product_quan_input
            // 
            this.product_quan_input.Location = new System.Drawing.Point(169, 228);
            this.product_quan_input.Name = "product_quan_input";
            this.product_quan_input.Size = new System.Drawing.Size(276, 40);
            this.product_quan_input.TabIndex = 8;
            this.product_quan_input.TextChanged += new System.EventHandler(this.product_quan_input_TextChanged);
            // 
            // Vendor_id_input
            // 
            this.Vendor_id_input.Location = new System.Drawing.Point(169, 167);
            this.Vendor_id_input.Name = "Vendor_id_input";
            this.Vendor_id_input.Size = new System.Drawing.Size(276, 40);
            this.Vendor_id_input.TabIndex = 7;
            this.Vendor_id_input.TextChanged += new System.EventHandler(this.Vendor_id_input_TextChanged);
            // 
            // Vendor_id
            // 
            this.Vendor_id.AutoSize = true;
            this.Vendor_id.Location = new System.Drawing.Point(16, 167);
            this.Vendor_id.Name = "Vendor_id";
            this.Vendor_id.Size = new System.Drawing.Size(141, 35);
            this.Vendor_id.TabIndex = 6;
            this.Vendor_id.Text = "vendor_id:";
            // 
            // product_quantity
            // 
            this.product_quantity.AutoSize = true;
            this.product_quantity.Location = new System.Drawing.Point(16, 237);
            this.product_quantity.Name = "product_quantity";
            this.product_quantity.Size = new System.Drawing.Size(125, 35);
            this.product_quantity.TabIndex = 5;
            this.product_quantity.Text = "Quantity:";
            // 
            // Product_name_input
            // 
            this.Product_name_input.Location = new System.Drawing.Point(169, 114);
            this.Product_name_input.Name = "Product_name_input";
            this.Product_name_input.Size = new System.Drawing.Size(276, 40);
            this.Product_name_input.TabIndex = 2;
            // 
            // Food_Name
            // 
            this.Food_Name.AutoSize = true;
            this.Food_Name.Location = new System.Drawing.Point(16, 114);
            this.Food_Name.Name = "Food_Name";
            this.Food_Name.Size = new System.Drawing.Size(92, 35);
            this.Food_Name.TabIndex = 2;
            this.Food_Name.Text = "Name:";
            // 
            // Product_id_input
            // 
            this.Product_id_input.Location = new System.Drawing.Point(168, 52);
            this.Product_id_input.Name = "Product_id_input";
            this.Product_id_input.Size = new System.Drawing.Size(277, 40);
            this.Product_id_input.TabIndex = 1;
            // 
            // Food_id
            // 
            this.Food_id.AutoSize = true;
            this.Food_id.Location = new System.Drawing.Point(16, 55);
            this.Food_id.Name = "Food_id";
            this.Food_id.Size = new System.Drawing.Size(48, 35);
            this.Food_id.TabIndex = 0;
            this.Food_id.Text = "ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.SaddleBrown;
            this.dataGridView1.Location = new System.Drawing.Point(791, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(439, 413);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Insert_Product
            // 
            this.Insert_Product.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Insert_Product.FlatAppearance.BorderSize = 2;
            this.Insert_Product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.Insert_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_Product.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Insert_Product.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Insert_Product.Location = new System.Drawing.Point(36, 165);
            this.Insert_Product.Name = "Insert_Product";
            this.Insert_Product.Size = new System.Drawing.Size(213, 53);
            this.Insert_Product.TabIndex = 28;
            this.Insert_Product.Text = "Insert Product";
            this.Insert_Product.UseVisualStyleBackColor = false;
            this.Insert_Product.Click += new System.EventHandler(this.Insert_Product_Click);
            // 
            // Delete_Product
            // 
            this.Delete_Product.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Delete_Product.FlatAppearance.BorderSize = 2;
            this.Delete_Product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.Delete_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Product.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Delete_Product.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_Product.Location = new System.Drawing.Point(36, 249);
            this.Delete_Product.Name = "Delete_Product";
            this.Delete_Product.Size = new System.Drawing.Size(213, 53);
            this.Delete_Product.TabIndex = 27;
            this.Delete_Product.Text = "Delete Product";
            this.Delete_Product.UseVisualStyleBackColor = false;
            this.Delete_Product.Click += new System.EventHandler(this.Delete_Product_Click);
            // 
            // Update_Product
            // 
            this.Update_Product.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Update_Product.FlatAppearance.BorderSize = 2;
            this.Update_Product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.Update_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Product.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Update_Product.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update_Product.Location = new System.Drawing.Point(36, 319);
            this.Update_Product.Name = "Update_Product";
            this.Update_Product.Size = new System.Drawing.Size(213, 53);
            this.Update_Product.TabIndex = 26;
            this.Update_Product.Text = "Update Product";
            this.Update_Product.UseVisualStyleBackColor = false;
            this.Update_Product.Click += new System.EventHandler(this.Update_Product_Click);
            // 
            // View_Product
            // 
            this.View_Product.BackColor = System.Drawing.Color.DarkSlateGray;
            this.View_Product.FlatAppearance.BorderSize = 2;
            this.View_Product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.View_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Product.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.View_Product.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.View_Product.Location = new System.Drawing.Point(36, 82);
            this.View_Product.Name = "View_Product";
            this.View_Product.Size = new System.Drawing.Size(213, 53);
            this.View_Product.TabIndex = 25;
            this.View_Product.Text = "View Product";
            this.View_Product.UseVisualStyleBackColor = false;
            this.View_Product.Click += new System.EventHandler(this.View_Product_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Back.FlatAppearance.BorderSize = 2;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(21, 566);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(213, 53);
            this.Back.TabIndex = 24;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Exit.FlatAppearance.BorderSize = 2;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(1033, 575);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(213, 53);
            this.Exit.TabIndex = 23;
            this.Exit.Text = "Exi&t";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Product_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.Product_CRUD_box);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Insert_Product);
            this.Controls.Add(this.Delete_Product);
            this.Controls.Add(this.Update_Product);
            this.Controls.Add(this.View_Product);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Name = "Product_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Detail";
            this.Product_CRUD_box.ResumeLayout(false);
            this.Product_CRUD_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Product_CRUD_box;
        private System.Windows.Forms.TextBox product_quan_input;
        private System.Windows.Forms.TextBox Vendor_id_input;
        private System.Windows.Forms.Label Vendor_id;
        private System.Windows.Forms.Label product_quantity;
        private System.Windows.Forms.TextBox Product_name_input;
        private System.Windows.Forms.Label Food_Name;
        private System.Windows.Forms.TextBox Product_id_input;
        private System.Windows.Forms.Label Food_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Insert_Product;
        private System.Windows.Forms.Button Delete_Product;
        private System.Windows.Forms.Button Update_Product;
        private System.Windows.Forms.Button View_Product;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Admin__id;
        private System.Windows.Forms.TextBox Admin_id_inputt;
    }
}