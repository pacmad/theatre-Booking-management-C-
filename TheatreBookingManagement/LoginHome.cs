using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using TheatreBookingManagement.DBEntity;


namespace TheatreBookingManagement
{
    public partial class LoginHome : Form
    {
        public LoginHome()
        {
            InitializeComponent();
        }
        DBEntities db= new DBEntities();
        private void buttonLogin_Click(object sender, EventArgs e)
        {

            foreach (var USER in db.USERS)
            {

                if (USER.Username == textBoxUsername.Text && USER.Password == textBoxPassword.Text)
                {
                    this.Hide();
                    HomeUSER hm = new HomeUSER();
                    hm.Show();
                    MessageBox.Show("Login successfull.");
                }

                else
                {

                    MessageBox.Show("Login unsuccessfull.");
                    clear();

                }
            }
            
        }
        private void clear()
        {

            textBoxUsername.Text = textBoxPassword.Text = "";
        
        
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminLoginForm Ad = new AdminLoginForm();
            Ad.Visible = true;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignupForm U1 = new UserSignupForm();
            U1.Show();
        }

       

        
    }
}
