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
    public partial class Supplier_Detail : Form
    {
        public Supplier_Detail()
        {
            InitializeComponent();
        }


        string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        private void View_Supplier_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [Supplier]";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Insert_Supplier_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Supplier values (@name,@phone,@productid,@adminid)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", Supplier_name_input.Text);
            cmd.Parameters.AddWithValue("@phone", Supplier_number_input.Text);
            cmd.Parameters.AddWithValue("@productid", product_id_input.Text);
            cmd.Parameters.AddWithValue("@adminid", Admin_id_inputt.Text);
            con.Open();

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show(" Supplier inserted sucessfully");





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
            Supplier_id_input.Text = "";
            Supplier_name_input.Text = "";
            Supplier_number_input.Text="";
            product_id_input.Text = "";
            Admin_id_inputt.Text="";



        }

        private void Delete_Supplier_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Delete from [Supplier] where Supplier_id=@id ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Supplier_id_input.Text.Trim());
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

        private void Update_Supplier_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Update [Supplier] set Supplier_name=@name,Supplier_phone=@number,Product_id= @productid,Admin_id=7833 where supplier_id=@id ";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", Supplier_name_input.Text.Trim());
            cmd.Parameters.AddWithValue("@number", Supplier_number_input.Text.Trim());
            cmd.Parameters.AddWithValue("@id", Supplier_id_input.Text.Trim());

            cmd.Parameters.AddWithValue("@productid", product_id_input.Text.Trim());
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
            Supplier_id_input.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Supplier_name_input.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Supplier_number_input.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            product_id_input.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Admin_id_inputt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Supplier_number_input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(Supplier_number_input.Text);
                if (a < 0)
                {
                    Supplier_number_input.Text = "";

                }

            }
            catch (Exception ex)
            {


                MessageBox.Show("netagtive value can't entered" + ex);
            }
        }

        private void product_id_input_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
