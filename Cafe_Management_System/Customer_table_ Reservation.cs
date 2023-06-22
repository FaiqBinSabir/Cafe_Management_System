using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Net.Mail;
using System.Net;
using System.Xml.Linq;

namespace Cafe_Management_System
{
    public partial class Customer_table__Reservation : Form
    {
        public Customer_table__Reservation()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select table_id, table_description,table_chairs from [Tables]";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();            
            Customer_page cs = new Customer_page();
            cs.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            chairs_input.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            table_number_input.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void clear_Click(object sender, EventArgs e)
        {
            chairs_input.Text = "";
            table_number_input.Text="";
            Customer_id_input.Text = "";
            email_input.Text = "";
            

        }


        

        private void button3_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [Reservations] where  Customer_id="+Convert.ToInt32(Customer_id_input.Text);
            con.Open();
           
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
           con.Close();
        }

        private void Reserve_Table_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into reservations values (@desc,@c_id,@t_id,@date)";

            SqlCommand cmd = new SqlCommand(query, con);

            string vq1;

            string userInput = dateTimePicker1.Text;
            if (DateTime.TryParse(userInput, out DateTime dateTimeValue))
            {
                vq1 = dateTimeValue.ToString();
                if (DateTime.Parse(dateTimePicker1.Text) < DateTime.Today)
                {
                    MessageBox.Show("Sorry cant reseve it as date passed..");

                    return;
                }

                dateTimePicker1.Text = vq1;

                cmd.Parameters.AddWithValue("@date", vq1);

            }


            else
            {
                MessageBox.Show("Invalid date/time format!");
            }
            cmd.Parameters.AddWithValue("@desc", reservation_desc_input.Text);
            cmd.Parameters.AddWithValue("@c_id", Customer_id_input.Text);
            cmd.Parameters.AddWithValue("@t_id", table_number_input.Text);
            con.Open();

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show(" reservation sucessfully");

                try
                {
                    MailMessage mail = new MailMessage("intakhabmalik0582001@gmail.com", email_input.Text, "Reservation Successful", "your reservation for table"+table_number_input.Text+ "booking on " + dateTimePicker1.Text + "  is confirmed. Thanks for using our application and we wish you had a pleasure experience at our cafe.");
                    SmtpClient c = new SmtpClient(smptt_input.Text);
                   // SmtpClient client = new SmtpClient(smtp.SelectedItem.ToString());
                    c.Port = 587;
                    c.Credentials = new NetworkCredential("intakhabmalik0582001@gmail.com", "vtmemfxitutemawx");
                    c.EnableSsl = true;
                    c.Send(mail);
                    MessageBox.Show("Email Sent!!", "Success", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }



            }
            else
            {

                MessageBox.Show("cant entered your data");
            }
            con.Close();

        }
    }
}
