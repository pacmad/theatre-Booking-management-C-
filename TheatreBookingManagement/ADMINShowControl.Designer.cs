namespace TheatreBookingManagement
{
    partial class ADMINShowControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.MID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheatreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theatreNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platinumSeatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goldSeatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silverSeatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHOWBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOWBOOKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Shows";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Location = new System.Drawing.Point(398, 288);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(117, 31);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.Color.Teal;
            this.buttonADD.FlatAppearance.BorderSize = 0;
            this.buttonADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonADD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonADD.Location = new System.Drawing.Point(105, 288);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(117, 31);
            this.buttonADD.TabIndex = 5;
            this.buttonADD.Text = "Add";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.AutoGenerateColumns = false;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MID,
            this.TheatreID,
            this.Date,
            this.Time,
            this.movieNameDataGridViewTextBoxColumn,
            this.theatreNameDataGridViewTextBoxColumn,
            this.hallDataGridViewTextBoxColumn,
            this.platinumSeatDataGridViewTextBoxColumn,
            this.goldSeatDataGridViewTextBoxColumn,
            this.silverSeatDataGridViewTextBoxColumn});
            this.dgvShow.DataSource = this.sHOWBOOKBindingSource;
            this.dgvShow.Location = new System.Drawing.Point(15, 53);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.Size = new System.Drawing.Size(537, 219);
            this.dgvShow.TabIndex = 4;
            this.dgvShow.DoubleClick += new System.EventHandler(this.dgvShow_DoubleClick);
            // 
            // MID
            // 
            this.MID.DataPropertyName = "MovieID";
            this.MID.HeaderText = "MovieID";
            this.MID.Name = "MID";
            this.MID.ReadOnly = true;
            this.MID.Visible = false;
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
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // movieNameDataGridViewTextBoxColumn
            // 
            this.movieNameDataGridViewTextBoxColumn.DataPropertyName = "MovieName";
            this.movieNameDataGridViewTextBoxColumn.HeaderText = "MovieName";
            this.movieNameDataGridViewTextBoxColumn.Name = "movieNameDataGridViewTextBoxColumn";
            this.movieNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // theatreNameDataGridViewTextBoxColumn
            // 
            this.theatreNameDataGridViewTextBoxColumn.DataPropertyName = "TheatreName";
            this.theatreNameDataGridViewTextBoxColumn.HeaderText = "TheatreName";
            this.theatreNameDataGridViewTextBoxColumn.Name = "theatreNameDataGridViewTextBoxColumn";
            this.theatreNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hallDataGridViewTextBoxColumn
            // 
            this.hallDataGridViewTextBoxColumn.DataPropertyName = "Hall";
            this.hallDataGridViewTextBoxColumn.HeaderText = "Hall";
            this.hallDataGridViewTextBoxColumn.Name = "hallDataGridViewTextBoxColumn";
            this.hallDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // platinumSeatDataGridViewTextBoxColumn
            // 
            this.platinumSeatDataGridViewTextBoxColumn.DataPropertyName = "PlatinumSeat";
            this.platinumSeatDataGridViewTextBoxColumn.HeaderText = "PlatinumSeat";
            this.platinumSeatDataGridViewTextBoxColumn.Name = "platinumSeatDataGridViewTextBoxColumn";
            this.platinumSeatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goldSeatDataGridViewTextBoxColumn
            // 
            this.goldSeatDataGridViewTextBoxColumn.DataPropertyName = "GoldSeat";
            this.goldSeatDataGridViewTextBoxColumn.HeaderText = "GoldSeat";
            this.goldSeatDataGridViewTextBoxColumn.Name = "goldSeatDataGridViewTextBoxColumn";
            this.goldSeatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // silverSeatDataGridViewTextBoxColumn
            // 
            this.silverSeatDataGridViewTextBoxColumn.DataPropertyName = "SilverSeat";
            this.silverSeatDataGridViewTextBoxColumn.HeaderText = "SilverSeat";
            this.silverSeatDataGridViewTextBoxColumn.Name = "silverSeatDataGridViewTextBoxColumn";
            this.silverSeatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sHOWBOOKBindingSource
            // 
            this.sHOWBOOKBindingSource.DataSource = typeof(TheatreBookingManagement.DBEntity.SHOWBOOK);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(249, 288);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 31);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ADMINShowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.dgvShow);
            this.Name = "ADMINShowControl";
            this.Size = new System.Drawing.Size(567, 371);
            this.Load += new System.EventHandler(this.ADMINShowControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOWBOOKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.BindingSource sHOWBOOKBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheatreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theatreNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platinumSeatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goldSeatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn silverSeatDataGridViewTextBoxColumn;
    }
}
