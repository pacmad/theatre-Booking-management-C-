namespace TheatreBookingManagement
{
    partial class AddEdit_ShowForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPlatinumseats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTheatreID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMovieID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGoldseats = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHallNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSilverseats = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxMovieName = new System.Windows.Forms.ComboBox();
            this.comboBoxTheatreName = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sHOWBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTheatreName = new System.Windows.Forms.TextBox();
            this.textBoxMovieName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sHOWBOOKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Name";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(385, 431);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(127, 38);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxPlatinumseats
            // 
            this.textBoxPlatinumseats.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sHOWBOOKBindingSource, "PlatinumSeat", true));
            this.textBoxPlatinumseats.Location = new System.Drawing.Point(697, 221);
            this.textBoxPlatinumseats.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlatinumseats.Name = "textBoxPlatinumseats";
            this.textBoxPlatinumseats.ReadOnly = true;
            this.textBoxPlatinumseats.Size = new System.Drawing.Size(182, 23);
            this.textBoxPlatinumseats.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(477, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Theatre Name";
            // 
            // textBoxTheatreID
            // 
            this.textBoxTheatreID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sHOWBOOKBindingSource, "TheatreID", true));
            this.textBoxTheatreID.Location = new System.Drawing.Point(145, 176);
            this.textBoxTheatreID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTheatreID.Name = "textBoxTheatreID";
            this.textBoxTheatreID.ReadOnly = true;
            this.textBoxTheatreID.Size = new System.Drawing.Size(221, 23);
            this.textBoxTheatreID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(25, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "MovieID";
            // 
            // textBoxMovieID
            // 
            this.textBoxMovieID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sHOWBOOKBindingSource, "MovieID", true));
            this.textBoxMovieID.Location = new System.Drawing.Point(145, 128);
            this.textBoxMovieID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMovieID.Name = "textBoxMovieID";
            this.textBoxMovieID.ReadOnly = true;
            this.textBoxMovieID.Size = new System.Drawing.Size(221, 23);
            this.textBoxMovieID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(25, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "TheatreID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(25, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date";
            // 
            // textBoxGoldseats
            // 
            this.textBoxGoldseats.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sHOWBOOKBindingSource, "GoldSeat", true));
            this.textBoxGoldseats.Location = new System.Drawing.Point(697, 277);
            this.textBoxGoldseats.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGoldseats.Name = "textBoxGoldseats";
            this.textBoxGoldseats.ReadOnly = true;
            this.textBoxGoldseats.Size = new System.Drawing.Size(182, 23);
            this.textBoxGoldseats.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(525, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Time";
            // 
            // textBoxHallNo
            // 
            this.textBoxHallNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sHOWBOOKBindingSource, "Hall", true));
            this.textBoxHallNo.Location = new System.Drawing.Point(697, 168);
            this.textBoxHallNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHallNo.Name = "textBoxHallNo";
            this.textBoxHallNo.ReadOnly = true;
            this.textBoxHallNo.Size = new System.Drawing.Size(182, 23);
            this.textBoxHallNo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(522, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hall";
            // 
            // textBoxSilverseats
            // 
            this.textBoxSilverseats.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sHOWBOOKBindingSource, "SilverSeat", true));
            this.textBoxSilverseats.Location = new System.Drawing.Point(697, 335);
            this.textBoxSilverseats.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSilverseats.Name = "textBoxSilverseats";
            this.textBoxSilverseats.ReadOnly = true;
            this.textBoxSilverseats.Size = new System.Drawing.Size(182, 23);
            this.textBoxSilverseats.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(522, 227);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "No. of Platinum Seats";
            // 
            // comboBoxMovieName
            // 
            this.comboBoxMovieName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sHOWBOOKBindingSource, "MovieName", true));
            this.comboBoxMovieName.FormattingEnabled = true;
            this.comboBoxMovieName.Location = new System.Drawing.Point(145, 31);
            this.comboBoxMovieName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMovieName.Name = "comboBoxMovieName";
            this.comboBoxMovieName.Size = new System.Drawing.Size(265, 25);
            this.comboBoxMovieName.TabIndex = 17;
            this.comboBoxMovieName.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMovieName_SelectionChangeCommitted);
            // 
            // comboBoxTheatreName
            // 
            this.comboBoxTheatreName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sHOWBOOKBindingSource, "TheatreName", true));
            this.comboBoxTheatreName.FormattingEnabled = true;
            this.comboBoxTheatreName.Location = new System.Drawing.Point(614, 31);
            this.comboBoxTheatreName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTheatreName.Name = "comboBoxTheatreName";
            this.comboBoxTheatreName.Size = new System.Drawing.Size(265, 25);
            this.comboBoxTheatreName.TabIndex = 18;
            this.comboBoxTheatreName.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTheatreName_SelectionChangeCommitted);
            // 
            // datePicker
            // 
            this.datePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sHOWBOOKBindingSource, "Date", true));
            this.datePicker.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(145, 311);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(221, 19);
            this.datePicker.TabIndex = 19;
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "  ";
            this.TimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sHOWBOOKBindingSource, "Time", true));
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(697, 126);
            this.TimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(182, 23);
            this.TimePicker.TabIndex = 20;
            this.TimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimePicker_KeyDown);
            this.TimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimePicker_MouseDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(522, 280);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "No. of Gold Seats";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(522, 334);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "No. of Silver Seats";
            // 
            // sHOWBOOKBindingSource
            // 
            this.sHOWBOOKBindingSource.DataSource = typeof(TheatreBookingManagement.DBEntity.SHOWBOOK);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(22, 266);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Movie Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(22, 227);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Theatre Name";
            // 
            // textBoxTheatreName
            // 
            this.textBoxTheatreName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sHOWBOOKBindingSource, "TheatreName", true));
            this.textBoxTheatreName.Location = new System.Drawing.Point(145, 224);
            this.textBoxTheatreName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTheatreName.Name = "textBoxTheatreName";
            this.textBoxTheatreName.ReadOnly = true;
            this.textBoxTheatreName.Size = new System.Drawing.Size(221, 23);
            this.textBoxTheatreName.TabIndex = 25;
            // 
            // textBoxMovieName
            // 
            this.textBoxMovieName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sHOWBOOKBindingSource, "MovieName", true));
            this.textBoxMovieName.Location = new System.Drawing.Point(145, 263);
            this.textBoxMovieName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMovieName.Name = "textBoxMovieName";
            this.textBoxMovieName.ReadOnly = true;
            this.textBoxMovieName.Size = new System.Drawing.Size(221, 23);
            this.textBoxMovieName.TabIndex = 26;
            // 
            // AddEdit_ShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(936, 503);
            this.Controls.Add(this.textBoxMovieName);
            this.Controls.Add(this.textBoxTheatreName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.comboBoxTheatreName);
            this.Controls.Add(this.comboBoxMovieName);
            this.Controls.Add(this.textBoxSilverseats);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxHallNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxGoldseats);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMovieID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTheatreID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPlatinumseats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEdit_ShowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEdit_ShowForm";
            this.Load += new System.EventHandler(this.AddEdit_ShowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sHOWBOOKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPlatinumseats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTheatreID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMovieID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGoldseats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxHallNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSilverseats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxMovieName;
        private System.Windows.Forms.ComboBox comboBoxTheatreName;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource sHOWBOOKBindingSource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTheatreName;
        private System.Windows.Forms.TextBox textBoxMovieName;
    }
}