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
    public partial class Customer_page : Form
    {
        public Customer_page()
        {
            InitializeComponent();
            this.FormClosing += Customer_Page_FormClosing;
        }

        private void Customer_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
