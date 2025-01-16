namespace hotel
{
    partial class UC_BookingHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBookings = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Olive;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking History";
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.AllowUserToResizeColumns = false;
            this.dgvBookings.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookings.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookings.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.dgvBookings.Location = new System.Drawing.Point(12, 30);
            this.dgvBookings.MultiSelect = false;
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookings.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookings.RowHeadersVisible = false;
            this.dgvBookings.RowTemplate.Height = 30;
            this.dgvBookings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBookings.Size = new System.Drawing.Size(708, 160);
            this.dgvBookings.TabIndex = 3;
            this.dgvBookings.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen;
            this.dgvBookings.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.dgvBookings.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvBookings.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBookings.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBookings.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBookings.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBookings.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.dgvBookings.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.dgvBookings.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBookings.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvBookings.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBookings.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBookings.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvBookings.ThemeStyle.ReadOnly = true;
            this.dgvBookings.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            this.dgvBookings.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBookings.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvBookings.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBookings.ThemeStyle.RowsStyle.Height = 30;
            this.dgvBookings.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            this.dgvBookings.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // UC_BookingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_BookingHistory";
            this.Size = new System.Drawing.Size(730, 200);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBookings;
    }
}
