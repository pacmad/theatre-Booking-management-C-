using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheatreBookingManagement
{
    public partial class HomesUserControl : UserControl
    {
        public HomesUserControl()
        {


            InitializeComponent();
        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {

            pictureBox2.Visible =false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Visible==true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }

            else if(pictureBox2.Visible==true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible =true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        
       
    }
}
