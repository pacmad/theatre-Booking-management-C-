using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheatreBookingManagement
{
    public partial class AdminSignUpForm : Form
    {
        public AdminSignUpForm()
        {
            InitializeComponent();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLoginForm Al = new AdminLoginForm();
            Al.Visible = true;
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

    }
}
