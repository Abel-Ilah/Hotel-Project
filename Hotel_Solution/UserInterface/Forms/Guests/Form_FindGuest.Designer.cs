namespace hotel
{
    partial class Form_FindGuest
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.uC_BookingHistory1 = new hotel.UC_BookingHistory();
            this.uC_GuestDetailsWithFilter1 = new hotel.UC_GuestDetailsWithFilter();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(710, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(31, 29);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // uC_BookingHistory1
            // 
            this.uC_BookingHistory1.BackColor = System.Drawing.Color.White;
            this.uC_BookingHistory1.Location = new System.Drawing.Point(3, 352);
            this.uC_BookingHistory1.Name = "uC_BookingHistory1";
            this.uC_BookingHistory1.Size = new System.Drawing.Size(730, 226);
            this.uC_BookingHistory1.TabIndex = 4;
            // 
            // uC_GuestDetailsWithFilter1
            // 
            this.uC_GuestDetailsWithFilter1.BackColor = System.Drawing.Color.White;
            this.uC_GuestDetailsWithFilter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_GuestDetailsWithFilter1.Location = new System.Drawing.Point(3, 39);
            this.uC_GuestDetailsWithFilter1.Name = "uC_GuestDetailsWithFilter1";
            this.uC_GuestDetailsWithFilter1.Size = new System.Drawing.Size(737, 321);
            this.uC_GuestDetailsWithFilter1.TabIndex = 5;
            this.uC_GuestDetailsWithFilter1.OnGuestFound += new System.Action<HotelProjectBusinessLayer.clsGuest>(this.uC_GuestDetailsWithFilter1_OnGuestFound);
            // 
            // Form_FindGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 550);
            this.Controls.Add(this.uC_BookingHistory1);
            this.Controls.Add(this.uC_GuestDetailsWithFilter1);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_FindGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ShowBookingHistoryOfGuest";
            this.Load += new System.EventHandler(this.Form_ShowBookingHistoryOfGuest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private UC_BookingHistory uC_BookingHistory1;
        private UC_GuestDetailsWithFilter uC_GuestDetailsWithFilter1;
    }
}