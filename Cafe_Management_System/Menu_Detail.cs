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
    public partial class Menu_Detail : Form
    {
        public Menu_Detail()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Delete_Menu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Delete from [Menu] where food_id=@id ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Menu_id_input.Text.Trim());
            con.Open();
           int a= cmd.ExecuteNonQuery();
            if (a>0)
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

        public void defult()
        {
            Menu_id_input.Text = "";
            Menu_name_input.Text= "";
            Menu_Price_input.Text = "";
            Admin_id_input.Text = "";
        }

        private void View_Menu_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
          


            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [Menu]";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

       

        private void Update_Menu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Update [Menu] set Food_name =@name,Food_price=@price,Admin_id= 7833 where food_id=@id ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Menu_id_input.Text.Trim());
            cmd.Parameters.AddWithValue("@name", Menu_name_input.Text.Trim());
            cmd.Parameters.AddWithValue("@price", Menu_Price_input.Text.Trim());
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

        private void Insert_Menu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Menu values (@name,@price,@id)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", Menu_name_input.Text);
            cmd.Parameters.AddWithValue("@price", Menu_Price_input.Text);
            cmd.Parameters.AddWithValue("@id",Admin_id_input.Text);
            con.Open();

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("account created sucessfully");
                this.Hide();
                Customer_signin cs = new Customer_signin();
                cs.Show();




            }
            else
            {

                MessageBox.Show("cant entered your data");
            }
            con.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_function admin_Function= new Admin_function();
            admin_Function.Show();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Menu_id_input.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Menu_name_input.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Menu_Price_input.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Admin_id_input.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
