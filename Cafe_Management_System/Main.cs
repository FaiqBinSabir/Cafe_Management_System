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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        

              this.FormClosing += Main_FormClosing;
        }

    private void Main_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }


    private void location_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start($"https://www.google.com/maps/search/?api=1&query={"Bahria University Karachi"}");
        
    }

        private void Instagram_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://www.instagram.com/{"i__faiq"}");

        }

        private void Whatsapp_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start($"https://wa.me/{"03442746152"}");
        }

        private void Facebook_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start($"https://www.facebook.com/{"faiqbinsabir"}");
        }

        private void Go_To_System_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login_forms login_f = new Login_forms();

           login_f.Show();
            

        }
    }
}
