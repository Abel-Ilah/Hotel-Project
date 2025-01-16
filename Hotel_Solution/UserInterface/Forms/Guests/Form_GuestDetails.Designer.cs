namespace hotel
{
    partial class Form_GuestDetails
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
            this.uC_GuestDetails1 = new hotel.UC_GuestDetails();
            this.uC_BookingHistory1 = new hotel.UC_BookingHistory();
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(697, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(31, 29);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // uC_GuestDetails1
            // 
            this.uC_GuestDetails1.BackColor = System.Drawing.Color.White;
            this.uC_GuestDetails1.Location = new System.Drawing.Point(0, 34);
            this.uC_GuestDetails1.Name = "uC_GuestDetails1";
            this.uC_GuestDetails1.Size = new System.Drawing.Size(730, 264);
            this.uC_GuestDetails1.TabIndex = 77;
            this.uC_GuestDetails1.OnGuestFound += new System.Action<HotelProjectBusinessLayer.clsGuest>(this.uC_GuestDetails1_OnGuestFound);
            // 
            // uC_BookingHistory1
            // 
            this.uC_BookingHistory1.BackColor = System.Drawing.Color.White;
            this.uC_BookingHistory1.Location = new System.Drawing.Point(0, 296);
            this.uC_BookingHistory1.Name = "uC_BookingHistory1";
            this.uC_BookingHistory1.Size = new System.Drawing.Size(730, 200);
            this.uC_BookingHistory1.TabIndex = 78;
            // 
            // Form_GuestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 497);
            this.Controls.Add(this.uC_BookingHistory1);
            this.Controls.Add(this.uC_GuestDetails1);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_GuestDetails";
            this.Text = "Form_GuestDetails";
            this.Load += new System.EventHandler(this.Form_GuestDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private UC_GuestDetails uC_GuestDetails1;
        private UC_BookingHistory uC_BookingHistory1;
    }
}