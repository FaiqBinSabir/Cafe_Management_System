using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Product_Detail : Form
    {
        public Product_Detail()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        private void View_Product_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;



            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [Products]";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Insert_Product_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Products values (@quantity,@desc,@vendorid,@adminid)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@quantity", product_quan_input.Text);
            cmd.Parameters.AddWithValue("@desc", Product_name_input.Text);
            cmd.Parameters.AddWithValue("@vendorid", Vendor_id_input.Text);
            cmd.Parameters.AddWithValue("@adminid", Admin_id_inputt.Text);
            con.Open();

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show(" Product inserted sucessfully");
              




            }
            else
            {

                MessageBox.Show("cant entered your data");
            }
            con.Close();
            defult();
        }

        public void defult()
        {
            Product_id_input.Text = "";
            product_quan_input.Text = "";
            Product_name_input.Text = "";
            Vendor_id_input.Text = "";
            Admin_id_inputt.Text = "";
        }
        //private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    Product_id_input.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        //    Product_name_input.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        //    product_quan_input.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        //    Vendor_id_input.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        //    Admin_id_inputt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        //}

        private void Delete_Product_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Delete from [Products] where Product_id=@id ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Product_id_input.Text.Trim());
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("item delted sucessfully");


            }
            else
            {

                MessageBox.Show("error occured");
            }


            defult();
            con.Close();
        }

       

        private void Update_Product_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Update [Products] set Product_quantity=@quantity,Product_description=@name,Admin_id= 7833,Vendor_id=@vid where product_id=@id ";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@quantity", product_quan_input.Text.Trim());
            cmd.Parameters.AddWithValue("@name", Product_name_input.Text.Trim());
            cmd.Parameters.AddWithValue("@vid", Vendor_id_input.Text.Trim());

            cmd.Parameters.AddWithValue("@id", Product_id_input.Text.Trim());
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("item updated sucessfully");


            }
            else
            {

                MessageBox.Show("error occured");
            }

            defult();
            con.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_function af = new Admin_function();
            af.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Product_id_input.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Product_name_input.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            product_quan_input.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Vendor_id_input.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Admin_id_inputt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void product_quan_input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(product_quan_input.Text);
                if (a < 0)
                {
                    product_quan_input.Text = "";

                }

            }
            catch (Exception ex)
            {


                MessageBox.Show("netagtive value can't entered"+ex);
            }
           
        }

        private void Vendor_id_input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(Vendor_id_input.Text);
                if (a < 0)
                {
                    Vendor_id_input.Text = "";

                }

            }
            catch (Exception ex)
            {


                MessageBox.Show("netagtive value can't entered" + ex);
            }
        }
    }
}