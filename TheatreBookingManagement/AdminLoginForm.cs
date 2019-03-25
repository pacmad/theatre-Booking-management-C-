using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TheatreBookingManagement;
using TheatreBookingManagement.DBEntity;


namespace TheatreBookingManagement
{
    public partial class AdminLoginForm : Form
    {
        DBEntities db= new DBEntities();
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSignUpForm ASG = new AdminSignUpForm();
            ASG.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            foreach (var ADMIN in db.ADMINs)
            {

                if (ADMIN.Username == textBoxUsername.Text && ADMIN.Password == textBoxPassword.Text)
                {
                    this.Hide();
                    HomeADMIN hm = new HomeADMIN();
                    hm.Show();
                    MessageBox.Show("Login successful.");
                }

                else
                {

                    MessageBox.Show("Sorry Login Unsuccessful");
                    clear();

                }
            }
            
        }
        private void clear() {

            textBoxUsername.Text = textBoxPassword.Text = "";
        
        
        
        }
    }
}
