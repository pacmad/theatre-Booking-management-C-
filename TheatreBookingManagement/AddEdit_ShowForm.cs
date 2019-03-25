using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace TheatreBookingManagement
{
    public partial class AddEdit_ShowForm : Form
    {
        SHOWBOOK model = new SHOWBOOK();

        string TheatreID;
        string MovieID;
        string dateTime;
        DBEntities db = new DBEntities();

        public AddEdit_ShowForm(SHOWBOOK obj, int TheatreID)
        {
            InitializeComponent();
            if (obj == null)
            {

                sHOWBOOKBindingSource.DataSource = new SHOWBOOK();

            }
            else
            {

                sHOWBOOKBindingSource.DataSource = obj;
                model = obj;
                model.ThreatreID = TheatreID;
                
                model = db.SHOWBOOKs.Where(x => x.ThreatreID == model.ThreatreID ).FirstOrDefault();
               // model = db.SHOWBOOKs.Where(y => y.Date == model.Date).FirstOrDefault();
                comboBoxTheatreName.Text = obj.TheatreName;
                comboBoxMovieName.Text = obj.MovieName;
                
                textBoxHallNo.Text = obj.Hall.ToString();
                textBoxPlatinumseats.Text = obj.PlatinumSeat.ToString();
                textBoxGoldseats.Text = obj.GoldSeat.ToString();
                textBoxSilverseats.Text = obj.SilverSeat.ToString();


                buttonSave.Text = "Update";


            }
        }

        private void AddEdit_ShowForm_Load(object sender, EventArgs e)
        {
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "dd-MM-yyyy";

            try
            {
                using (DBEntities db = new DBEntities()) 
                {
                    comboBoxMovieName.DataSource = db.Movies.ToList();
                    comboBoxMovieName.ValueMember = "MID";
                    comboBoxMovieName.DisplayMember = "Name";

                    
                
                
                
                }
                using (DBEntities db = new DBEntities()) 
                
                {

                    comboBoxTheatreName.DataSource = db.THEATREBOOKs.ToList();
                    comboBoxTheatreName.ValueMember = "TID";
                    comboBoxTheatreName.DisplayMember = "Name";
                
                
                
                }
                

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void TimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            TimePicker.CustomFormat = "HH:mm";
        }

        private void TimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {

                TimePicker.CustomFormat = " ";
            
            }
        }

       

        private void comboBoxMovieName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            MOVIE obj = comboBoxMovieName.SelectedItem as MOVIE;
            if (obj != null) 
            {
                textBoxMovieID.Text = obj.MovieID.ToString();
                textBoxMovieName.Text = obj.Name.ToString();

            
            
            }
            Cursor.Current = Cursors.Default;
        }

        private void comboBoxTheatreName_SelectionChangeCommitted(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            THEATREBOOK obj = comboBoxTheatreName.SelectedItem as THEATREBOOK;
            if (obj != null)
            {
                textBoxTheatreID.Text = obj.TheatreID.ToString();
                textBoxTheatreName.Text = obj.Name.ToString();
                textBoxHallNo.Text = obj.Hall.ToString();
                textBoxPlatinumseats.Text = obj.Platinum.ToString();
                textBoxGoldseats.Text = obj.Gold.ToString();
                textBoxSilverseats.Text = obj.Silver.ToString();



            }
            Cursor.Current = Cursors.Default;




        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (buttonSave.Text == "Save")
            {
                TheatreID = Regex.Match(textBoxTheatreID.Text, @"\d+").Value;
                MovieID = Regex.Match(textBoxMovieID.Text, @"\d+").Value;
                dateTime = Convert.ToString(TimePicker.Text);

                model.MovieName = textBoxMovieName.Text.Trim();
                model.TheatreName = textBoxTheatreName.Text.Trim();
                model.ThreatreID = Convert.ToInt32(TheatreID.Trim());
                model.MovieID = Convert.ToInt32(MovieID.Trim());
                model.Hall = Convert.ToInt32(textBoxHallNo.Text.Trim());
                model.PlatinumSeat = Convert.ToInt32(textBoxPlatinumseats.Text.Trim());
                model.GoldSeat = Convert.ToInt32(textBoxGoldseats.Text.Trim());
                model.SilverSeat = Convert.ToInt32(textBoxSilverseats.Text.Trim());
                model.Date = Convert.ToDateTime(datePicker.Text.Trim());
                model.Time = TimeSpan.Parse(dateTime);


                
                using (DBEntities db = new DBEntities())
                {

                    db.SHOWBOOKs.Add(model);

                    db.SaveChanges();

                }

                
                MessageBox.Show("Your Show details are submitted");
            }
            else
            {
                model = db.SHOWBOOKs.Where(x => x.ThreatreID == model.ThreatreID).FirstOrDefault();
               // model = db.SHOWBOOKs.Where(y => y.Date == model.Date).FirstOrDefault();

                 TheatreID = Regex.Match(textBoxTheatreID.Text, @"\d+").Value;
                 MovieID = Regex.Match(textBoxMovieID.Text, @"\d+").Value;
                // dateTime = Convert.ToString(TimePicker.Text);

                model.MovieName = comboBoxMovieName.Text.Trim();
                model.TheatreName = comboBoxTheatreName.Text.Trim();
                model.ThreatreID = Convert.ToInt32(TheatreID.Trim());
                model.MovieID = Convert.ToInt32(MovieID.Trim());
                model.Hall = Convert.ToInt32(textBoxHallNo.Text.Trim());
                model.PlatinumSeat = Convert.ToInt32(textBoxPlatinumseats.Text.Trim());
                model.GoldSeat = Convert.ToInt32(textBoxGoldseats.Text.Trim());
                model.SilverSeat = Convert.ToInt32(textBoxSilverseats.Text.Trim());
               // model.Date = Convert.ToDateTime(datePicker.Text.Trim());
                //model.Time = TimeSpan.Parse(dateTime);

                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();

                
                MessageBox.Show("Your SHOW details are Updated");


            }
        }
    }
}
