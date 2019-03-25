using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TheatreBookingManagement.DBEntity;

namespace TheatreBookingManagement
{
    public partial class ADMINMoviesControl : UserControl
    {
        DBEntities db;
        MOVIE model = new MOVIE();
        public ADMINMoviesControl()
        {
            InitializeComponent();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            using (AddEdit_MovieForm frm = new AddEdit_MovieForm(null,0))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    mOVIEBindingSource.DataSource = db.Movies.ToList();


                }

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (mOVIEBindingSource.Current != null)
            {

                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.Movies.Remove(mOVIEBindingSource.Current as MOVIE);
                    mOVIEBindingSource.RemoveCurrent();
                    db.SaveChanges();


                }


            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            db = new DBEntities();
            mOVIEBindingSource.DataSource = db.Movies.ToList();
        }

        private void ADMINMoviesControl_Load(object sender, EventArgs e)
        {
            db = new DBEntities();
            mOVIEBindingSource.DataSource = db.Movies.ToList();
        }

        private void dgvMovies_DoubleClick(object sender, EventArgs e)
        {
            model.MID = Convert.ToInt32(dgvMovies.CurrentRow.Cells["MID"].Value);
            using (AddEdit_MovieForm frm = new AddEdit_MovieForm(mOVIEBindingSource.Current as MOVIE, model.MID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    mOVIEBindingSource.DataSource = db.Movies.ToList();


                }

            }
        }
    }
}
