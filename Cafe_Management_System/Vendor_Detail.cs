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
    public partial class Vendor_Detail : Form
    {
        public Vendor_Detail()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        private void View_Vendor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [Vendor]";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        public void defult()
        {

            Vendor_name_input.Text="";
            Vendor_number_input.Text = "";
            Vendor_id_input.Text = "";
            Vendor_address_input.Text="";
            Admin_id_inputt.Text = "";
        }

        private void Insert_Vendor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Vendor values (@name,@phone,@address,@adminid)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", Vendor_name_input.Text);
            cmd.Parameters.AddWithValue("@phone", Vendor_number_input.Text);
            cmd.Parameters.AddWithValue("@address", Vendor_address_input.Text);
            cmd.Parameters.AddWithValue("@adminid", Admin_id_inputt.Text);
            con.Open();

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show(" Vendor inserted sucessfully");





            }
            else
            {

                MessageBox.Show("cant entered your data");
            }
            con.Close();
            defult();
        }

        private void Delete_Vendor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Delete from [Vendor] where Vendor_id=@id ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Vendor_id_input.Text.Trim());
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Vendor delted sucessfully");


            }
            else
            {

                MessageBox.Show("error occured");
            }


            defult();
            con.Close();
        }

        private void Update_Vendor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Update [Vendor] set Vendor_name=@name,Vendor_phone=@number,Vendor_address= @address,Admin_id=7833 where vendor_id=@id ";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", Vendor_name_input.Text.Trim());
            cmd.Parameters.AddWithValue("@number", Vendor_number_input.Text.Trim());
            cmd.Parameters.AddWithValue("@id", Vendor_id_input.Text.Trim());

            cmd.Parameters.AddWithValue("@address", Vendor_address_input.Text.Trim());
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("vendor updated sucessfully");


            }
            else
            {

                MessageBox.Show("error occured");
            }
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
           Vendor_id_input.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Vendor_name_input.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Vendor_number_input.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Vendor_address_input.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Admin_id_inputt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
    }

