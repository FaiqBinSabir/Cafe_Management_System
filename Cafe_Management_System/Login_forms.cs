using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Login_forms : Form
    {
        public Login_forms()
        {
            InitializeComponent();
        }

        private void Login_forms_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }


        private void Admin_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_page admin_p = new Admin_page();
            admin_p.Show();
        }

       

        private void Customer_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_page cs = new Customer_page();
            cs.Show();
        }

        private void Chef_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chef_page chef_p = new Chef_page();
            chef_p.Show();
        }

       
        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main_p = new Main();
            main_p.Show();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
