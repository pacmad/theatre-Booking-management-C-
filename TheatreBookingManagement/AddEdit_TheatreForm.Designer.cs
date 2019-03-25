namespace TheatreBookingManagement
{
    partial class AddEdit_TheatreForm
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tHEATREBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxPlatinumSeat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHallno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGoldSeat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSilverSeat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tHEATREBOOKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSave.Location = new System.Drawing.Point(185, 334);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(108, 32);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHEATREBOOKBindingSource, "Name", true));
            this.textBoxName.Location = new System.Drawing.Point(213, 72);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(212, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // tHEATREBOOKBindingSource
            // 
            this.tHEATREBOOKBindingSource.DataSource = typeof(TheatreBookingManagement.DBEntity.THEATREBOOK);
            // 
            // textBoxPlatinumSeat
            // 
            this.textBoxPlatinumSeat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHEATREBOOKBindingSource, "Platinum", true));
            this.textBoxPlatinumSeat.Location = new System.Drawing.Point(213, 204);
            this.textBoxPlatinumSeat.Name = "textBoxPlatinumSeat";
            this.textBoxPlatinumSeat.Size = new System.Drawing.Size(212, 20);
            this.textBoxPlatinumSeat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(43, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hall No.";
            // 
            // textBoxHallno
            // 
            this.textBoxHallno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHEATREBOOKBindingSource, "Hall", true));
            this.textBoxHallno.Location = new System.Drawing.Point(213, 167);
            this.textBoxHallno.Name = "textBoxHallno";
            this.textBoxHallno.Size = new System.Drawing.Size(212, 20);
            this.textBoxHallno.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(43, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHEATREBOOKBindingSource, "Address", true));
            this.textBoxAddress.Location = new System.Drawing.Point(213, 115);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(212, 37);
            this.textBoxAddress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(41, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "No. of Platinum Seat";
            // 
            // textBoxGoldSeat
            // 
            this.textBoxGoldSeat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHEATREBOOKBindingSource, "Gold", true));
            this.textBoxGoldSeat.Location = new System.Drawing.Point(213, 240);
            this.textBoxGoldSeat.Name = "textBoxGoldSeat";
            this.textBoxGoldSeat.Size = new System.Drawing.Size(212, 20);
            this.textBoxGoldSeat.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(43, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "No. of Gold Seat";
            // 
            // textBoxSilverSeat
            // 
            this.textBoxSilverSeat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHEATREBOOKBindingSource, "Silver", true));
            this.textBoxSilverSeat.Location = new System.Drawing.Point(213, 280);
            this.textBoxSilverSeat.Name = "textBoxSilverSeat";
            this.textBoxSilverSeat.Size = new System.Drawing.Size(212, 20);
            this.textBoxSilverSeat.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(41, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "No. of Silver Seat";
            // 
            // AddEdit_TheatreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 391);
            this.Controls.Add(this.textBoxSilverSeat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxGoldSeat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHallno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPlatinumSeat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddEdit_TheatreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEdit_TheatreForm";
            ((System.ComponentModel.ISupportInitialize)(this.tHEATREBOOKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPlatinumSeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHallno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGoldSeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSilverSeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource tHEATREBOOKBindingSource;
    }
}