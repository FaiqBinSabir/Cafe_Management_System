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
    public partial class Admin_page : Form
    {
        public Admin_page()
        {
            InitializeComponent();
            this.FormClosing += Admin_Page_FormClosing;
        }

        private void Admin_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_forms login_f = new Login_forms();
            login_f.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
