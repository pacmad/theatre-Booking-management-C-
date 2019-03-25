namespace TheatreBookingManagement
{
    partial class HomeUSER
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
            this.panelNav = new System.Windows.Forms.Panel();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonMovies = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.labeloutHead = new System.Windows.Forms.Label();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.homesUserControl1 = new TheatreBookingManagement.HomesUserControl();
            this.settingsUserControl1 = new TheatreBookingManagement.SettingsUserControl();
            this.profileUserControl1 = new TheatreBookingManagement.ProfileUserControl();
            this.movieUserControl1 = new TheatreBookingManagement.MovieUserControl();
            this.panelNav.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelNav.Controls.Add(this.Sidepanel);
            this.panelNav.Controls.Add(this.buttonLogout);
            this.panelNav.Controls.Add(this.buttonSettings);
            this.panelNav.Controls.Add(this.buttonProfile);
            this.panelNav.Controls.Add(this.buttonMovies);
            this.panelNav.Controls.Add(this.buttonHome);
            this.panelNav.Controls.Add(this.label1);
            this.panelNav.Controls.Add(this.shapeContainer1);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(200, 526);
            this.panelNav.TabIndex = 0;
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.Maroon;
            this.Sidepanel.Location = new System.Drawing.Point(0, 96);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(10, 42);
            this.Sidepanel.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(-1, 352);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(198, 44);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Location = new System.Drawing.Point(-1, 284);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(198, 44);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "SETTINGS";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.ForeColor = System.Drawing.Color.White;
            this.buttonProfile.Location = new System.Drawing.Point(0, 219);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(198, 44);
            this.buttonProfile.TabIndex = 4;
            this.buttonProfile.Text = "PROFILE";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonMovies
            // 
            this.buttonMovies.FlatAppearance.BorderSize = 0;
            this.buttonMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovies.ForeColor = System.Drawing.Color.White;
            this.buttonMovies.Location = new System.Drawing.Point(0, 159);
            this.buttonMovies.Name = "buttonMovies";
            this.buttonMovies.Size = new System.Drawing.Size(197, 44);
            this.buttonMovies.TabIndex = 3;
            this.buttonMovies.Text = "SHOWS";
            this.buttonMovies.UseVisualStyleBackColor = true;
            this.buttonMovies.Click += new System.EventHandler(this.buttonMovies_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(-1, 94);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(198, 44);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.Text = "HOME";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navigation";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(200, 526);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Maroon;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 7;
            this.lineShape1.X2 = 197;
            this.lineShape1.Y1 = 66;
            this.lineShape1.Y2 = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "WELCOME ";
            // 
            // labeloutHead
            // 
            this.labeloutHead.AutoSize = true;
            this.labeloutHead.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeloutHead.ForeColor = System.Drawing.Color.White;
            this.labeloutHead.Location = new System.Drawing.Point(210, 25);
            this.labeloutHead.Name = "labeloutHead";
            this.labeloutHead.Size = new System.Drawing.Size(0, 22);
            this.labeloutHead.TabIndex = 2;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Maroon;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -3;
            this.lineShape2.X2 = 619;
            this.lineShape2.Y1 = 66;
            this.lineShape2.Y2 = 67;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labeloutHead);
            this.panel2.Controls.Add(this.shapeContainer3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 74);
            this.panel2.TabIndex = 4;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer3.Size = new System.Drawing.Size(622, 74);
            this.shapeContainer3.TabIndex = 3;
            this.shapeContainer3.TabStop = false;
            // 
            // homesUserControl1
            // 
            this.homesUserControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homesUserControl1.Location = new System.Drawing.Point(206, 83);
            this.homesUserControl1.Name = "homesUserControl1";
            this.homesUserControl1.Size = new System.Drawing.Size(583, 431);
            this.homesUserControl1.TabIndex = 9;
            // 
            // settingsUserControl1
            // 
            this.settingsUserControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.settingsUserControl1.Location = new System.Drawing.Point(206, 83);
            this.settingsUserControl1.Name = "settingsUserControl1";
            this.settingsUserControl1.Size = new System.Drawing.Size(593, 431);
            this.settingsUserControl1.TabIndex = 8;
            // 
            // profileUserControl1
            // 
            this.profileUserControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profileUserControl1.Location = new System.Drawing.Point(200, 80);
            this.profileUserControl1.Name = "profileUserControl1";
            this.profileUserControl1.Size = new System.Drawing.Size(613, 446);
            this.profileUserControl1.TabIndex = 7;
            // 
            // movieUserControl1
            // 
            this.movieUserControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movieUserControl1.Location = new System.Drawing.Point(197, 80);
            this.movieUserControl1.Name = "movieUserControl1";
            this.movieUserControl1.Size = new System.Drawing.Size(616, 367);
            this.movieUserControl1.TabIndex = 6;
            // 
            // HomeUSER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(822, 526);
            this.Controls.Add(this.homesUserControl1);
            this.Controls.Add(this.settingsUserControl1);
            this.Controls.Add(this.profileUserControl1);
            this.Controls.Add(this.movieUserControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNav);
            this.Name = "HomeUSER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeUSER";
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonMovies;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeloutHead;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private MovieUserControl movieUserControl1;
        private ProfileUserControl profileUserControl1;
        private SettingsUserControl settingsUserControl1;
        private HomesUserControl homesUserControl1;
    }
}