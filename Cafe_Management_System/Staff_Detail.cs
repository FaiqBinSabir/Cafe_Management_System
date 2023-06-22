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
    public partial class Staff_Detail : Form
    {
        public Staff_Detail()
        {
            InitializeComponent();
        }


        string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        private void View_Staff_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [staff]";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Insert_Staff_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into staff values (@id,@name,@phone,@email,@password,adminid,@type)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", Staff_name_input.Text);
            cmd.Parameters.AddWithValue("@phone", Staff_number_input.Text);
            cmd.Parameters.AddWithValue("@id", Staff_id_input.Text);
            cmd.Parameters.AddWithValue("@adminid", 7833);
            cmd.Parameters.AddWithValue("@email", Staff__email_input.Text);
            cmd.Parameters.AddWithValue("@type", staff_type_input.Text);

            cmd.Parameters.AddWithValue("@password", Staff_password_inputt.Text.ToString());
            con.Open();

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show(" Staff inserted sucessfully");





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

            staff_type_input.Text = "";
            Staff_id_input.Text = "";
            Staff_name_input.Text = "";
            Staff_password_inputt.Text = "";
            Staff__email_input.Text = "";
            Admin_id_input.Text = "";
            Staff_number_input.Text = "";
        }

        private void Delete_Staff_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Delete from [Staff] where Staff_id=@id ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Staff_id_input.Text.Trim());
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

        private void Update_Staff_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Update [Staff] set staff_password=@password,staff_type=@type,Staff_name=@name,Staff_number=@phone,staff_email= @email,Admin_id=7833 where staff_id=@id ";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", Staff_name_input.Text);
            cmd.Parameters.AddWithValue("@phone", Staff_number_input.Text);
            cmd.Parameters.AddWithValue("@id", Staff_id_input.Text);
            cmd.Parameters.AddWithValue("@adminid", Admin_id_input.Text);
            cmd.Parameters.AddWithValue("@email", Staff__email_input.Text);
            cmd.Parameters.AddWithValue("@password", Staff_password_inputt.Text);
            cmd.Parameters.AddWithValue("@type", staff_type_input.Text);
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

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Staff_id_input.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Staff_name_input.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Staff_number_input.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Staff__email_input.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Staff_password_inputt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Admin_id_input.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            staff_type_input.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
