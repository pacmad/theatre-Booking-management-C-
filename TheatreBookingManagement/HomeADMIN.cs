using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TheatreBookingManagement.DBEntity;

namespace TheatreBookingManagement
{
    public partial class HomeADMIN : Form
    {
        DBEntities db = new DBEntities();
        public HomeADMIN()
        {
            InitializeComponent();
        }

        private void buttonMovies_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonMovies.Height;
            Sidepanel.Top = buttonMovies.Top;
            adminMoviesControl1.BringToFront();
        }

        private void buttonTheatre_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonTheatre.Height;
            Sidepanel.Top = buttonTheatre.Top;
            adminTheatreControl1.BringToFront();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = buttonShow.Height;
            Sidepanel.Top = buttonShow.Top;
            adminShowControl1.BringToFront();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
           

            this.Hide();
            LoginHome lh = new LoginHome();
            lh.Show();

            MessageBox.Show("YOU ARE LOGGED OUT.Thank You ");
        }


    }
}
