using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookingManagement.DBEntity;


namespace TheatreBookingManagement
{
    public partial class MovieUserControl : UserControl
    {
        public MovieUserControl()
        {
            InitializeComponent();
        }

        private void comboBoxMovie_SelectionChangeCommitted(object sender, EventArgs e)
        {

            SHOWBOOK obj = comboBoxMovie.SelectedItem as SHOWBOOK;
            if (obj != null) {

                using (DBEntities db = new DBEntities()) 
                {


                    mOVIEBindingSource.DataSource = db.Movies.Where(p => p.MID == obj.MovieID).ToList();
                }
            
            
            }

        }

        private void MovieUserControl_Load(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                sHOWBOOKBindingSource.DataSource = db.SHOWBOOKs.ToList();
                SHOWBOOK obj = comboBoxMovie.SelectedItem as SHOWBOOK;
                if (obj != null)
                {
                    mOVIEBindingSource.DataSource = db.Movies.Where(p => p.MID == obj.MovieID).ToList();

                }
            }

            using (DBEntities db = new DBEntities())
            {
                sHOWBOOKBindingSource.DataSource = db.SHOWBOOKs.ToList();
                SHOWBOOK obj = comboBoxDate.SelectedItem as SHOWBOOK;
                if (obj != null)
                {
                    sHOWBOOKBindingSource.DataSource = db.SHOWBOOKs.Where(p => p.Date== obj.Date).ToList();

                }
            }






        }

        private void comboBoxDate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SHOWBOOK obj = comboBoxDate.SelectedItem as SHOWBOOK;
            if (obj != null)
            {

                using (DBEntities db = new DBEntities())
                {


                    sHOWBOOKBindingSource.DataSource = db.SHOWBOOKs.Where(p => p.Date == obj.Date).ToList();
                }


            }
        }

        private void dgvUserMovie_DoubleClick(object sender, EventArgs e)
        {







        }
    }
}
