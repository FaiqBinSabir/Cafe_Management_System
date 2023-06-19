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
    public partial class Receptionist_page : Form
    {
        public Receptionist_page()
        {
            InitializeComponent();
        }

        private void Receptionist_Page_FormClosing(object sender, FormClosingEventArgs e)
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
