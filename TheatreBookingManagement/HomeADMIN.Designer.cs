using TheatreBookingManagement.DBEntity;
namespace TheatreBookingManagement
{
    partial class HomeADMIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonTheatre = new System.Windows.Forms.Button();
            this.buttonMovies = new System.Windows.Forms.Button();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminTheatreControl1 = new TheatreBookingManagement.ADMINTheatreControl();
            this.adminShowControl1 = new TheatreBookingManagement.ADMINShowControl();
            this.adminMoviesControl1 = new TheatreBookingManagement.ADMINMoviesControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.buttonShow);
            this.panel1.Controls.Add(this.buttonTheatre);
            this.panel1.Controls.Add(this.buttonMovies);
            this.panel1.Controls.Add(this.Sidepanel);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 489);
            this.panel1.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(3, 322);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(197, 44);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.ForeColor = System.Drawing.Color.White;
            this.buttonShow.Location = new System.Drawing.Point(3, 272);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(197, 44);
            this.buttonShow.TabIndex = 7;
            this.buttonShow.Text = "SHOWS";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonTheatre
            // 
            this.buttonTheatre.FlatAppearance.BorderSize = 0;
            this.buttonTheatre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTheatre.ForeColor = System.Drawing.Color.White;
            this.buttonTheatre.Location = new System.Drawing.Point(3, 222);
            this.buttonTheatre.Name = "buttonTheatre";
            this.buttonTheatre.Size = new System.Drawing.Size(197, 44);
            this.buttonTheatre.TabIndex = 6;
            this.buttonTheatre.Text = "THEATRE";
            this.buttonTheatre.UseVisualStyleBackColor = true;
            this.buttonTheatre.Click += new System.EventHandler(this.buttonTheatre_Click);
            // 
            // buttonMovies
            // 
            this.buttonMovies.FlatAppearance.BorderSize = 0;
            this.buttonMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovies.ForeColor = System.Drawing.Color.White;
            this.buttonMovies.Location = new System.Drawing.Point(1, 172);
            this.buttonMovies.Name = "buttonMovies";
            this.buttonMovies.Size = new System.Drawing.Size(197, 44);
            this.buttonMovies.TabIndex = 5;
            this.buttonMovies.Text = "MOVIES";
            this.buttonMovies.UseVisualStyleBackColor = true;
            this.buttonMovies.Click += new System.EventHandler(this.buttonMovies_Click);
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.Maroon;
            this.Sidepanel.Location = new System.Drawing.Point(0, 124);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(10, 42);
            this.Sidepanel.TabIndex = 4;
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(0, 122);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(198, 44);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.Text = "HOME";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Navigation";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(200, 489);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Maroon;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 3;
            this.lineShape1.X2 = 197;
            this.lineShape1.Y1 = 84;
            this.lineShape1.Y2 = 85;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.shapeContainer3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 93);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "WELCOME ";
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer3.Size = new System.Drawing.Size(622, 93);
            this.shapeContainer3.TabIndex = 11;
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Maroon;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -4;
            this.lineShape2.X2 = 619;
            this.lineShape2.Y1 = 85;
            this.lineShape2.Y2 = 86;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.adminTheatreControl1);
            this.panel3.Controls.Add(this.adminShowControl1);
            this.panel3.Controls.Add(this.adminMoviesControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 396);
            this.panel3.TabIndex = 0;
            // 
            // adminTheatreControl1
            // 
            this.adminTheatreControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminTheatreControl1.Location = new System.Drawing.Point(4, 6);
            this.adminTheatreControl1.Name = "adminTheatreControl1";
            this.adminTheatreControl1.Size = new System.Drawing.Size(607, 371);
            this.adminTheatreControl1.TabIndex = 2;
            // 
            // adminShowControl1
            // 
            this.adminShowControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminShowControl1.Location = new System.Drawing.Point(6, 3);
            this.adminShowControl1.Name = "adminShowControl1";
            this.adminShowControl1.Size = new System.Drawing.Size(604, 371);
            this.adminShowControl1.TabIndex = 1;
            // 
            // adminMoviesControl1
            // 
            this.adminMoviesControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminMoviesControl1.Location = new System.Drawing.Point(6, 0);
            this.adminMoviesControl1.Name = "adminMoviesControl1";
            this.adminMoviesControl1.Size = new System.Drawing.Size(604, 348);
            this.adminMoviesControl1.TabIndex = 0;
            // 
            // HomeADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 489);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomeADMIN";
            this.Text = "HomeADMIN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonTheatre;
        private System.Windows.Forms.Button buttonMovies;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private ADMINTheatreControl adminTheatreControl1;
        private ADMINShowControl adminShowControl1;
        private ADMINMoviesControl adminMoviesControl1;
    }
}