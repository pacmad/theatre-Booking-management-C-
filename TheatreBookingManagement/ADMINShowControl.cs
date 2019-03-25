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
    public partial class ADMINShowControl : UserControl
    {
        DBEntities db;

        SHOWBOOK model = new SHOWBOOK();
        public ADMINShowControl()
        {
            InitializeComponent();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            using (AddEdit_ShowForm frm = new AddEdit_ShowForm(null,0))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    sHOWBOOKBindingSource.DataSource = db.SHOWBOOKs.ToList();


                }

            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            model.ThreatreID = Convert.ToInt32(dgvShow.CurrentRow.Cells["TheatreID"].Value);
            model.Date = Convert.ToDateTime(dgvShow.CurrentRow.Cells["Date"].Value);
           


            using (AddEdit_ShowForm frm = new AddEdit_ShowForm(sHOWBOOKBindingSource.Current as SHOWBOOK, model.ThreatreID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    sHOWBOOKBindingSource.DataSource = db.SHOWBOOKs.ToList();


                }

            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            db = new DBEntities();
            sHOWBOOKBindingSource.DataSource = db.SHOWBOOKs.ToList();
        }

        private void ADMINShowControl_Load(object sender, EventArgs e)
        {
            db = new DBEntities();
            sHOWBOOKBindingSource.DataSource = db.SHOWBOOKs.ToList();
        }

        private void dgvShow_DoubleClick(object sender, EventArgs e)
        {
            model.ThreatreID = Convert.ToInt32(dgvShow.CurrentRow.Cells["TheatreID"].Value);
            model.Date = Convert.ToDateTime(dgvShow.CurrentRow.Cells["Date"].Value);
            using (AddEdit_ShowForm frm = new AddEdit_ShowForm(sHOWBOOKBindingSource.Current as SHOWBOOK, model.ThreatreID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    sHOWBOOKBindingSource.DataSource = db.THEATREBOOKs.ToList();


                }

            }
        }
    }
}
