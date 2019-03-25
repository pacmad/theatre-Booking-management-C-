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
    public partial class ADMINTheatreControl : UserControl
    {
        DBEntities db;
        
         THEATREBOOK model = new THEATREBOOK();
        public ADMINTheatreControl()
        {
            InitializeComponent();
        }

        private void ADMINTheatreControl_Load(object sender, EventArgs e)
        {
            db = new DBEntities();
            tHEATREBOOKBindingSource.DataSource = db.THEATREBOOKs.ToList();

        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
             using(AddEdit_TheatreForm frm = new AddEdit_TheatreForm(null,0))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    tHEATREBOOKBindingSource.DataSource = db.THEATREBOOKs.ToList();
                
                
                }

            }
        }

        private void dgvTheatre_DoubleClick(object sender, EventArgs e)
        {
            model.TID = Convert.ToInt32(dgvTheatre.CurrentRow.Cells["TID"].Value);
            using (AddEdit_TheatreForm frm = new AddEdit_TheatreForm(tHEATREBOOKBindingSource.Current as THEATREBOOK,model.TID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    tHEATREBOOKBindingSource.DataSource = db.THEATREBOOKs.ToList();


                }

            }
           
            
           



            }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (tHEATREBOOKBindingSource.Current != null) {

                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Operation", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                    db.THEATREBOOKs.Remove(tHEATREBOOKBindingSource.Current as THEATREBOOK);
                    tHEATREBOOKBindingSource.RemoveCurrent();
                    db.SaveChanges();

                
                }
            
            
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            db = new DBEntities();
            tHEATREBOOKBindingSource.DataSource = db.THEATREBOOKs.ToList();
        }


        }
    }

