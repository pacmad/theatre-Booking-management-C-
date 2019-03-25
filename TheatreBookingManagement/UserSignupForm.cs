
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using TheatreBookingManagement.DBEntity;

namespace TheatreBookingManagement
{
    public partial class UserSignupForm : Form
    {
        USER model = new USER();


      

        public UserSignupForm()
        {
            InitializeComponent();
        }

        private void labelCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginHome Lh = new LoginHome();
            Lh.Show();
        }

       


        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^\d{11}").Success;
        }

        public static bool IsUserName(string name)
        {
            return Regex.Match(name, @"^[A-z][A-z|\.|\s]+$").Success;
        }

        public static bool IsPassword(string password)
        {
            return Regex.Match(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$").Success;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToString();
            string fullName = txtFullname.Text.ToString();
            string email = txtEmail.Text.ToString();
            string password = txtPass.Text.ToString();
            string phone = txtPhone.Text.ToString();


            if (txtName.Text == "" && txtFullname.Text == "" && txtEmail.Text == "" && txtPass.Text == "" && txtPhone.Text == "")
            {
                errorProvider1.SetError(this.txtName, "Username can't contain any character or blank space");
                errorProvider1.SetError(this.txtFullname, "Name can't contain any character or blank space");
                errorProvider1.SetError(this.txtEmail, "This is not a valid Email");
                errorProvider1.SetError(this.txtPass, "Password have to contain atleast 1 special char and upper and lower case and length should be at least 8");
                errorProvider1.SetError(this.txtPhone, "phone number must be at least 11 char and start with +88");

            }

            else if (IsUserName(name) == true)
            {
                errorProvider1.Clear();

                if (IsUserName(fullName) == true)
                {
                    errorProvider1.Clear();

                    if (IsValidEmail(email) == true)
                    {
                        errorProvider1.Clear();

                        if (IsPassword(password) == true)
                        {
                            errorProvider1.Clear();

                            if (IsPhoneNumber(phone) == true)
                            {
                                errorProvider1.Clear();

                                model.Username = txtName.Text.Trim();
                                model.Fullname = txtFullname.Text.Trim();
                                model.Email = txtEmail.Text.Trim();
                                model.Password = txtPass.Text.Trim();
                                model.Phone = Convert.ToInt64(txtPhone.Text.Trim());

                                try
                                {
                                    using (DBEntities db = new DBEntities())
                                    {

                                        db.USERS.Add(model);

                                        db.SaveChanges();

                                    }


                                    MessageBox.Show("Your Theatre details are submitted");
                                }
                                catch(Exception ep)
                                {

                                    MessageBox.Show(ep.ToString());
                                
                                
                                }

                                //insert adding query to the database for name, fullname, email, pass, phone

                            }
                            else
                                errorProvider1.SetError(this.txtPhone, "phone number must be at least 11 char and start with +88");
                        }
                        else
                            errorProvider1.SetError(this.txtPass, "Password have to contain atleast 1 special char and upper and lower case and length should be at least 8");
                    }
                    else
                        errorProvider1.SetError(this.txtEmail, "This is not a valid Email");
                }
                else
                    errorProvider1.SetError(this.txtFullname, "Name can't contain any character or blank space");
            }
            else
                errorProvider1.SetError(this.txtName, "Username can't contain any character or blank space");


        }



    }
}



/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TheatreManagement.DBEntity;
using System.Text.RegularExpressions;
 
namespace TheatreBookingManagement
{
    public partial class UserSignupForm : Form
    {

        USER model = new USER();


        DBEntities db = new DBEntities();
 
        public UserSignupForm()
        {
            InitializeComponent();
           
        }
 
        private void labelCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 
        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginHome Lh = new LoginHome();
            Lh.Show();
        }
 
       
    
 
 
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
       
        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^\+(8{2})\d{11}").Success;
        }
 
        public static bool IsUserName(string name)
        {
            return Regex.Match(name, @"^[A-z][A-z|\.|\s]+$").Success;
        }
 
        public static bool IsPassword(string password)
        {
            return Regex.Match(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$").Success;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
                    string name = txtName.Text.ToString();
            string fullName = txtFullname.Text.ToString();
            string email = txtEmail.Text.ToString();
            string password = txtPass.Text.ToString();
            string phone = txtPhone.Text.ToString();
 
            if(IsUserName(name) == true)
            {
                errorProvider1.Clear();
 
                if (IsUserName(fullName) == true)
                {
                    errorProvider1.Clear();
 
                    if(IsValidEmail(email)==true)
                    {
                      errorProvider1.Clear();
 
                        if(IsPassword(password) == true)
                        {
                           errorProvider1.Clear();
 
                            if(IsPhoneNumber(phone) == true)
                            {
                               errorProvider1.Clear();

                               model.Username = txtName.Text.Trim();
                               model.Fullname = txtFullname.Text.Trim();
                               model.Email = txtEmail.Text.Trim();
                               model.Password = txtPass.Text.Trim();
                               model.Phone = Convert.ToInt32(txtPhone.Text.Trim());
                               

                               using (DBEntities db = new DBEntities())
                               {

                                   db.USERS.Add(model);

                                   db.SaveChanges();

                               }

                               
                               MessageBox.Show("Your Theatre details are submitted");
 
 
                                //insert adding query to the database for name, fullname, email, pass, phone
 
                            }
                               errorProvider1.SetError(this.txtPhone, "phone number must be at least 11 char and start with +88");
                        }
                       errorProvider1.SetError(this.txtPass, "Password have to contain atleast 1 special char and upper and lower case and length should be at least 8");
                    }
                   errorProvider1.SetError(this.txtEmail, "This is not a valid Email");
                }
                errorProvider1.SetError(this.txtFullname, "Name can't contain any character or blank space");
            }
           errorProvider1.SetError(this.txtName, "Username can't contain any character or blank space");
 
           
        }
        }
 
       
       
    }



*/














































