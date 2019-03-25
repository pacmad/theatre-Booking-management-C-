using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TheatreBookingManagement.DBEntity;
using System.IO;

namespace TheatreBookingManagement
{
    public partial class AddEdit_TheatreForm : Form
    {
        THEATREBOOK model = new THEATREBOOK();


        DBEntities db = new DBEntities();


        public AddEdit_TheatreForm(THEATREBOOK obj, int TID)
        {

            InitializeComponent();

            if (obj == null)
            {

                tHEATREBOOKBindingSource.DataSource = new THEATREBOOK();

            }
            else
            {

                tHEATREBOOKBindingSource.DataSource = obj;
                model = obj;
                model.TID = TID;
                model = db.THEATREBOOKs.Where(x => x.TID == model.TID).FirstOrDefault();
                textBoxName.Text = obj.Name;
                textBoxAddress.Text = obj.Address;
                textBoxHallno.Text = obj.Hall.ToString();
                textBoxPlatinumSeat.Text = obj.Platinum.ToString();
                textBoxGoldSeat.Text = obj.Gold.ToString();
                textBoxSilverSeat.Text = obj.Silver.ToString();


                buttonSave.Text = "Update";


            }
        }


        void clear()
        {
            textBoxPlatinumSeat.Text = textBoxSilverSeat.Text = textBoxGoldSeat.Text = textBoxAddress.Text = textBoxHallno.Text = textBoxName.Text = "";

        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (buttonSave.Text == "Save")
            {
                try
                {
                    model.Name = textBoxName.Text.Trim();
                    model.Address = textBoxAddress.Text.Trim();
                    model.Hall = Convert.ToInt32(textBoxHallno.Text.Trim());
                    model.Platinum = Convert.ToInt32(textBoxPlatinumSeat.Text.Trim());
                    model.Gold = Convert.ToInt32(textBoxGoldSeat.Text.Trim());
                    model.Silver = Convert.ToInt32(textBoxSilverSeat.Text.Trim());

                    using (DBEntities db = new DBEntities())
                    {

                        db.THEATREBOOKs.Add(model);

                        db.SaveChanges();

                    }

                    clear();
                    MessageBox.Show("Your Theatre details are submitted");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                
                }
            }
            else
            {
                try
                {
                    model = db.THEATREBOOKs.Where(x => x.TID == model.TID).FirstOrDefault();

                    model.Name = textBoxName.Text.Trim();
                    model.Address = textBoxAddress.Text.Trim();
                    model.Hall = Convert.ToInt32(textBoxHallno.Text.Trim());
                    model.Platinum = Convert.ToInt32(textBoxPlatinumSeat.Text.Trim());
                    model.Gold = Convert.ToInt32(textBoxGoldSeat.Text.Trim());
                    model.Silver = Convert.ToInt32(textBoxSilverSeat.Text.Trim());

                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();

                    clear();
                    MessageBox.Show("Your Theatre details are Updated");
                }
                catch (Exception ep) 
                {
                    MessageBox.Show(ep.ToString());
                
                
                }

                 
            }








        }
    }
}

    

