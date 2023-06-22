namespace Cafe_Management_System
{
    partial class Customer_table__Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_table__Reservation));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Reserve_Table = new System.Windows.Forms.Button();
            this.email_input = new System.Windows.Forms.TextBox();
            this.Customer_id_input = new System.Windows.Forms.TextBox();
            this.chairs_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reservation_desc_input = new System.Windows.Forms.RichTextBox();
            this.clear = new System.Windows.Forms.Button();
            this.table_number_input = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.smptt_input = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(297, 46);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(13, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 35);
            this.label6.TabIndex = 27;
            this.label6.Text = "Table No:";
            // 
            // Reserve_Table
            // 
            this.Reserve_Table.BackColor = System.Drawing.Color.Black;
            this.Reserve_Table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reserve_Table.FlatAppearance.BorderSize = 2;
            this.Reserve_Table.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.Reserve_Table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reserve_Table.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reserve_Table.ForeColor = System.Drawing.Color.SeaShell;
            this.Reserve_Table.Location = new System.Drawing.Point(297, 389);
            this.Reserve_Table.Margin = new System.Windows.Forms.Padding(4);
            this.Reserve_Table.Name = "Reserve_Table";
            this.Reserve_Table.Size = new System.Drawing.Size(120, 39);
            this.Reserve_Table.TabIndex = 25;
            this.Reserve_Table.Text = "Reserve ";
            this.Reserve_Table.UseVisualStyleBackColor = false;
            this.Reserve_Table.Click += new System.EventHandler(this.Reserve_Table_Click);
            // 
            // email_input
            // 
            this.email_input.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.email_input.Location = new System.Drawing.Point(297, 247);
            this.email_input.Margin = new System.Windows.Forms.Padding(4);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(161, 40);
            this.email_input.TabIndex = 24;
            this.email_input.Text = " ";
            // 
            // Customer_id_input
            // 
            this.Customer_id_input.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Customer_id_input.Location = new System.Drawing.Point(297, 191);
            this.Customer_id_input.Margin = new System.Windows.Forms.Padding(4);
            this.Customer_id_input.Name = "Customer_id_input";
            this.Customer_id_input.Size = new System.Drawing.Size(161, 40);
            this.Customer_id_input.TabIndex = 23;
            // 
            // chairs_input
            // 
            this.chairs_input.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chairs_input.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.chairs_input.Location = new System.Drawing.Point(297, 136);
            this.chairs_input.Margin = new System.Windows.Forms.Padding(4);
            this.chairs_input.Name = "chairs_input";
            this.chairs_input.ReadOnly = true;
            this.chairs_input.Size = new System.Drawing.Size(161, 40);
            this.chairs_input.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(13, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 35);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 35);
            this.label3.TabIndex = 19;
            this.label3.Text = "Reservation Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Number Of Chairs:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enter Customer ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.reservation_desc_input);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.table_number_input);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Reserve_Table);
            this.groupBox1.Controls.Add(this.email_input);
            this.groupBox1.Controls.Add(this.Customer_id_input);
            this.groupBox1.Controls.Add(this.chairs_input);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(280, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 435);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservation Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(7, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 35);
            this.label5.TabIndex = 34;
            this.label5.Text = "Additional Description:";
            // 
            // reservation_desc_input
            // 
            this.reservation_desc_input.Location = new System.Drawing.Point(297, 300);
            this.reservation_desc_input.Name = "reservation_desc_input";
            this.reservation_desc_input.Size = new System.Drawing.Size(161, 74);
            this.reservation_desc_input.TabIndex = 33;
            this.reservation_desc_input.Text = "";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Black;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderSize = 2;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.SeaShell;
            this.clear.Location = new System.Drawing.Point(66, 389);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(120, 39);
            this.clear.TabIndex = 32;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // table_number_input
            // 
            this.table_number_input.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.table_number_input.Location = new System.Drawing.Point(297, 76);
            this.table_number_input.Margin = new System.Windows.Forms.Padding(4);
            this.table_number_input.Name = "table_number_input";
            this.table_number_input.Size = new System.Drawing.Size(161, 40);
            this.table_number_input.TabIndex = 31;
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
            this.Back.Size = new System.Drawing.Size(197, 53);
            this.Back.TabIndex = 32;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 53);
            this.button2.TabIndex = 33;
            this.button2.Text = "View Tables";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Exit.FlatAppearance.BorderSize = 2;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(1073, 575);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(197, 53);
            this.Exit.TabIndex = 34;
            this.Exit.Text = "Exi&t";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(798, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(472, 409);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(12, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 53);
            this.button3.TabIndex = 36;
            this.button3.Text = "View Reservation";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // smptt_input
            // 
            this.smptt_input.Location = new System.Drawing.Point(81, 408);
            this.smptt_input.Name = "smptt_input";
            this.smptt_input.Size = new System.Drawing.Size(127, 22);
            this.smptt_input.TabIndex = 37;
            this.smptt_input.Text = "smtp.gmail.com";
            this.smptt_input.Visible = false;
            // 
            // Customer_table__Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.smptt_input);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.groupBox1);
            this.Name = "Customer_table__Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_table__Reservation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Reserve_Table;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.TextBox Customer_id_input;
        private System.Windows.Forms.TextBox chairs_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox table_number_input;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox reservation_desc_input;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox smptt_input;
    }
}