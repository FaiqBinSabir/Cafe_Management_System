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
            this.FormClosing += Login_forms_FormClosing;
        }

        private void Login_forms_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void Admin_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_page admin_p = new Admin_page();
            admin_p.Show();
        }

        private void Waiter_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Waiter_page waiter_p = new Waiter_page();
            waiter_p.Show();
        }

        private void Customer_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_page customer_p = new Customer_page();
            customer_p.Show();
        }

        private void Chef_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chef_page chef_p = new Chef_page();
            chef_p.Show();
        }

        private void Receptionist_sign_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receptionist_page receptionist_p = new Receptionist_page();
            receptionist_p.Show();
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
