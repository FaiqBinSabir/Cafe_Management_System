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
    public partial class Chef_page : Form
    {
        public Chef_page()
        {
            InitializeComponent();
            this.FormClosing += Chef_Page_FormClosing;
        }
   
        private void Chef_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Chef_page_Load(object sender, EventArgs e)
        {

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
