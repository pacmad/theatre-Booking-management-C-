namespace TheatreBookingManagement
{
    partial class ADMINTheatreControl
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
            this.dgvTheatre = new System.Windows.Forms.DataGridView();
            this.tHEATREBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theatreIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platinumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheatre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEATREBOOKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Theatre";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Location = new System.Drawing.Point(396, 307);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(117, 31);
            this.buttonRefresh.TabIndex = 10;
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
            this.buttonADD.Location = new System.Drawing.Point(107, 307);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(117, 31);
            this.buttonADD.TabIndex = 9;
            this.buttonADD.Text = "Add";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // dgvTheatre
            // 
            this.dgvTheatre.AllowUserToAddRows = false;
            this.dgvTheatre.AllowUserToDeleteRows = false;
            this.dgvTheatre.AutoGenerateColumns = false;
            this.dgvTheatre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheatre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TID,
            this.theatreIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.hallDataGridViewTextBoxColumn,
            this.platinumDataGridViewTextBoxColumn,
            this.goldDataGridViewTextBoxColumn,
            this.silverDataGridViewTextBoxColumn});
            this.dgvTheatre.DataSource = this.tHEATREBOOKBindingSource;
            this.dgvTheatre.Location = new System.Drawing.Point(17, 72);
            this.dgvTheatre.Name = "dgvTheatre";
            this.dgvTheatre.ReadOnly = true;
            this.dgvTheatre.Size = new System.Drawing.Size(537, 219);
            this.dgvTheatre.TabIndex = 8;
            this.dgvTheatre.DoubleClick += new System.EventHandler(this.dgvTheatre_DoubleClick);
            // 
            // tHEATREBOOKBindingSource
            // 
            this.tHEATREBOOKBindingSource.DataSource = typeof(TheatreBookingManagement.DBEntity.THEATREBOOK);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(252, 307);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 31);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // TID
            // 
            this.TID.DataPropertyName = "TID";
            this.TID.HeaderText = "TID";
            this.TID.Name = "TID";
            this.TID.ReadOnly = true;
            this.TID.Visible = false;
            // 
            // theatreIDDataGridViewTextBoxColumn
            // 
            this.theatreIDDataGridViewTextBoxColumn.DataPropertyName = "TheatreID";
            this.theatreIDDataGridViewTextBoxColumn.HeaderText = "TheatreID";
            this.theatreIDDataGridViewTextBoxColumn.Name = "theatreIDDataGridViewTextBoxColumn";
            this.theatreIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hallDataGridViewTextBoxColumn
            // 
            this.hallDataGridViewTextBoxColumn.DataPropertyName = "Hall";
            this.hallDataGridViewTextBoxColumn.HeaderText = "Hall";
            this.hallDataGridViewTextBoxColumn.Name = "hallDataGridViewTextBoxColumn";
            this.hallDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // platinumDataGridViewTextBoxColumn
            // 
            this.platinumDataGridViewTextBoxColumn.DataPropertyName = "Platinum";
            this.platinumDataGridViewTextBoxColumn.HeaderText = "Platinum";
            this.platinumDataGridViewTextBoxColumn.Name = "platinumDataGridViewTextBoxColumn";
            this.platinumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goldDataGridViewTextBoxColumn
            // 
            this.goldDataGridViewTextBoxColumn.DataPropertyName = "Gold";
            this.goldDataGridViewTextBoxColumn.HeaderText = "Gold";
            this.goldDataGridViewTextBoxColumn.Name = "goldDataGridViewTextBoxColumn";
            this.goldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // silverDataGridViewTextBoxColumn
            // 
            this.silverDataGridViewTextBoxColumn.DataPropertyName = "Silver";
            this.silverDataGridViewTextBoxColumn.HeaderText = "Silver";
            this.silverDataGridViewTextBoxColumn.Name = "silverDataGridViewTextBoxColumn";
            this.silverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ADMINTheatreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.dgvTheatre);
            this.Name = "ADMINTheatreControl";
            this.Size = new System.Drawing.Size(567, 371);
            this.Load += new System.EventHandler(this.ADMINTheatreControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheatre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEATREBOOKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.DataGridView dgvTheatre;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.BindingSource tHEATREBOOKBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn theatreIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platinumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn silverDataGridViewTextBoxColumn;
    }
}
