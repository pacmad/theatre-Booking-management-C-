using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TheatreBookingManagement.DBEntity;

namespace TheatreBookingManagement

{
    
    public partial class AddEdit_MovieForm : Form
    {
        string filename;

        MOVIE model = new MOVIE();
        

        DBEntities db = new DBEntities();
        
        public AddEdit_MovieForm(MOVIE obj,int MID)
        {
            InitializeComponent();
           
            if (obj == null)
            {

                mOVIEBindingSource.DataSource = new MOVIE();
               



            }
            else
            {

                mOVIEBindingSource.DataSource = obj;
                model = obj;
                model.MID = MID;
                model = db.Movies.Where(x => x.MID == obj.MID).FirstOrDefault();
                textBoxName.Text = obj.Name;
                textBoxDirector.Text = obj.Director;
                textBoxCast.Text = obj.Cast;
                textBoxGenre.Text = obj.Genre;
                textBoxRating.Text = obj.Rating.ToString(); 
                pictureBox.Image=ConvertBinaryToImage(obj.Poster);


                buttonSave.Text = "Update";

            }
        }

        Image ConvertBinaryToImage(byte[] data)
        { 
        
        using(MemoryStream ms = new MemoryStream(data))
        {
            return Image.FromStream(ms);

        }
        
        }
        byte[] ConvertImageToBinary(Image img) 
        {

            using (MemoryStream ms = new MemoryStream()) 
            {

                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            
            }
        
        
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd= new OpenFileDialog() {Filter="JPEG|*.jpg",ValidateNames=true, Multiselect=false})
            {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    filename = ofd.FileName;
                    pictureBox.Image = Image.FromFile(filename);
                
                }
            } 

         
        }
       /* private   void savepic() 
        {

            using (DBEntities db = new DBEntities())
            {
                MOVIE mv = new MOVIE() { Poster = ConvertImageToBinary(pictureBox.Image) };
                db.Movies.Add(mv);
                db.SaveChanges();
                MessageBox.Show("You have submitted the picture ");


            
            }
        
        
        }*/

     

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (buttonSave.Text == "Save")
            {
                try
                {

                    model.Name = textBoxName.Text.Trim();
                    model.Director = textBoxDirector.Text.Trim();
                    model.Cast = textBoxCast.Text.Trim();
                    model.Genre = textBoxGenre.Text.Trim();
                    model.Rating = Convert.ToDecimal(textBoxRating.Text.Trim());
                    model.Poster = ConvertImageToBinary(pictureBox.Image);

                    using (DBEntities db = new DBEntities())
                    {
                        db.Movies.Add(model);

                        db.SaveChanges();
                    }
                    
                    MessageBox.Show("Your Movie details are submitted");
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
            }
            else
            {
                try
                {

                    model = db.Movies.Where(x => x.MID == model.MID).FirstOrDefault();

                    model.Name = textBoxName.Text.Trim();
                    model.Director = textBoxDirector.Text.Trim();
                    model.Cast = textBoxCast.Text.Trim();
                    model.Genre = textBoxGenre.Text.Trim();
                    model.Rating = Convert.ToDecimal(textBoxRating.Text.Trim());
                    model.Poster = ConvertImageToBinary(pictureBox.Image);

                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();



                    MessageBox.Show("Your Movie details are Updated");
                }
                catch (Exception ep)
                {
                    MessageBox.Show(ep.ToString());
                }
            }


            }


        }
    }

