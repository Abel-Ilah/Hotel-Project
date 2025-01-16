namespace hotel
{
    partial class UC_Revenue
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPeriodFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalBookings = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 68);
            this.label1.TabIndex = 0;
            // 
            // cmbPeriodFilter
            // 
            this.cmbPeriodFilter.BackColor = System.Drawing.Color.White;
            this.cmbPeriodFilter.BorderColor = System.Drawing.Color.Transparent;
            this.cmbPeriodFilter.BorderRadius = 15;
            this.cmbPeriodFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPeriodFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbPeriodFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriodFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriodFilter.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.cmbPeriodFilter.ForeColor = System.Drawing.Color.White;
            this.cmbPeriodFilter.IntegralHeight = false;
            this.cmbPeriodFilter.ItemHeight = 30;
            this.cmbPeriodFilter.Items.AddRange(new object[] {
            "Today",
            "Last 7 Days",
            "Last 30 Days",
            "Last 90 Days",
            "Last 365 Days"});
            this.cmbPeriodFilter.Location = new System.Drawing.Point(204, 60);
            this.cmbPeriodFilter.Name = "cmbPeriodFilter";
            this.cmbPeriodFilter.Size = new System.Drawing.Size(215, 36);
            this.cmbPeriodFilter.TabIndex = 79;
            this.cmbPeriodFilter.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 80;
            this.label2.Text = "Total Bookings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalBookings
            // 
            this.lbTotalBookings.BackColor = System.Drawing.Color.Red;
            this.lbTotalBookings.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBookings.ForeColor = System.Drawing.Color.White;
            this.lbTotalBookings.Location = new System.Drawing.Point(2, 32);
            this.lbTotalBookings.Name = "lbTotalBookings";
            this.lbTotalBookings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTotalBookings.Size = new System.Drawing.Size(206, 25);
            this.lbTotalBookings.TabIndex = 81;
            this.lbTotalBookings.Text = "0";
            this.lbTotalBookings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 3);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 82;
            this.label4.Text = "Revenue";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRevenue
            // 
            this.lbRevenue.BackColor = System.Drawing.Color.Red;
            this.lbRevenue.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevenue.ForeColor = System.Drawing.Color.White;
            this.lbRevenue.Location = new System.Drawing.Point(212, 32);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbRevenue.Size = new System.Drawing.Size(206, 25);
            this.lbRevenue.TabIndex = 83;
            this.lbRevenue.Text = "0 $";
            this.lbRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-5, 66);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 84;
            this.label3.Text = "Periode >>>";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPeriodFilter);
            this.Controls.Add(this.lbRevenue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTotalBookings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_Revenue";
            this.Size = new System.Drawing.Size(420, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPeriodFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalBookings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbRevenue;
        private System.Windows.Forms.Label label3;
    }
}
