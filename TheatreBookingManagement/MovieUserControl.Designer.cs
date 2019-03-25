namespace TheatreBookingManagement
{
    partial class MovieUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvUserMovie = new System.Windows.Forms.DataGridView();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheatreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theatreNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHOWBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.comboBoxMovie = new System.Windows.Forms.ComboBox();
            this.mOVIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOWBOOKBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserMovie
            // 
            this.dgvUserMovie.AllowUserToAddRows = false;
            this.dgvUserMovie.AllowUserToDeleteRows = false;
            this.dgvUserMovie.AutoGenerateColumns = false;
            this.dgvUserMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieID,
            this.TheatreID,
            this.Date,
            this.timeDataGridViewTextBoxColumn,
            this.MovieName,
            this.theatreNameDataGridViewTextBoxColumn});
            this.dgvUserMovie.DataSource = this.sHOWBOOKBindingSource;
            this.dgvUserMovie.Location = new System.Drawing.Point(11, 98);
            this.dgvUserMovie.Name = "dgvUserMovie";
            this.dgvUserMovie.ReadOnly = true;
            this.dgvUserMovie.Size = new System.Drawing.Size(539, 200);
            this.dgvUserMovie.TabIndex = 0;
            this.dgvUserMovie.DoubleClick += new System.EventHandler(this.dgvUserMovie_DoubleClick);
            // 
            // MovieID
            // 
            this.MovieID.DataPropertyName = "MovieID";
            this.MovieID.HeaderText = "MovieID";
            this.MovieID.Name = "MovieID";
            this.MovieID.ReadOnly = true;
            this.MovieID.Visible = false;
            // 
            // TheatreID
            // 
            this.TheatreID.DataPropertyName = "TheatreID";
            this.TheatreID.HeaderText = "TheatreID";
            this.TheatreID.Name = "TheatreID";
            this.TheatreID.ReadOnly = true;
            this.TheatreID.Visible = false;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MovieName
            // 
            this.MovieName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MovieName.DataPropertyName = "MovieName";
            this.MovieName.HeaderText = "MovieName";
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            // 
            // theatreNameDataGridViewTextBoxColumn
            // 
            this.theatreNameDataGridViewTextBoxColumn.DataPropertyName = "TheatreName";
            this.theatreNameDataGridViewTextBoxColumn.HeaderText = "TheatreName";
            this.theatreNameDataGridViewTextBoxColumn.Name = "theatreNameDataGridViewTextBoxColumn";
            this.theatreNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sHOWBOOKBindingSource
            // 
            this.sHOWBOOKBindingSource.DataSource = typeof(TheatreBookingManagement.DBEntity.SHOWBOOK);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SHOWS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxDate);
            this.panel1.Controls.Add(this.comboBoxMovie);
            this.panel1.Location = new System.Drawing.Point(16, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 42);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(282, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(25, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Movie";
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.DataSource = this.sHOWBOOKBindingSource;
            this.comboBoxDate.DisplayMember = "Date";
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(334, 18);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDate.TabIndex = 1;
            this.comboBoxDate.ValueMember = "Date";
            this.comboBoxDate.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDate_SelectionChangeCommitted);
            // 
            // comboBoxMovie
            // 
            this.comboBoxMovie.DataSource = this.sHOWBOOKBindingSource;
            this.comboBoxMovie.DisplayMember = "MovieName";
            this.comboBoxMovie.FormattingEnabled = true;
            this.comboBoxMovie.Location = new System.Drawing.Point(77, 18);
            this.comboBoxMovie.Name = "comboBoxMovie";
            this.comboBoxMovie.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMovie.TabIndex = 0;
            this.comboBoxMovie.ValueMember = "MovieID";
            this.comboBoxMovie.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMovie_SelectionChangeCommitted);
            // 
            // mOVIEBindingSource
            // 
            this.mOVIEBindingSource.DataSource = typeof(TheatreBookingManagement.DBEntity.MOVIE);
            // 
            // MovieUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUserMovie);
            this.Name = "MovieUserControl";
            this.Size = new System.Drawing.Size(562, 374);
            this.Load += new System.EventHandler(this.MovieUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOWBOOKBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.ComboBox comboBoxMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheatreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn theatreNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sHOWBOOKBindingSource;
        private System.Windows.Forms.BindingSource mOVIEBindingSource;
    }
}
