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
    public partial class HomeUSER : Form
    {
       
        public HomeUSER()
        {
            InitializeComponent();
           
            Sidepanel.Height = buttonHome.Height;
            Sidepanel.Top = buttonHome.Top;
            homesUserControl1.BringToFront();

        }


       
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU ARE LOGGED OUT.Thank You ");
            
            this.Hide();
            LoginHome lh = new LoginHome();
            lh.Show();

           
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

            Sidepanel.Height = buttonHome.Height;
            Sidepanel.Top = buttonHome.Top;
            homesUserControl1.BringToFront();


        }

        private void buttonMovies_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonMovies.Height;
            Sidepanel.Top = buttonMovies.Top;
            movieUserControl1.BringToFront();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonProfile.Height;
            Sidepanel.Top = buttonProfile.Top;
            profileUserControl1.BringToFront();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {


            Sidepanel.Height = buttonSettings.Height;
            Sidepanel.Top = buttonSettings.Top;
            settingsUserControl1.BringToFront();

        }

       

      
      
    }
}
