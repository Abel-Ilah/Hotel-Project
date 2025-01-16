namespace hotel
{
    partial class MainForm
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
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoomTypes = new Guna.UI2.WinForms.Guna2Button();
            this.btnMore = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindGuest = new Guna.UI2.WinForms.Guna2Button();
            this.btnBookings = new Guna.UI2.WinForms.Guna2Button();
            this.btnRooms = new Guna.UI2.WinForms.Guna2Button();
            this.uC_Revenue1 = new hotel.UC_Revenue();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(899, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(31, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MainPanel.Controls.Add(this.guna2Separator1);
            this.MainPanel.Controls.Add(this.lbDate);
            this.MainPanel.Controls.Add(this.guna2CirclePictureBox1);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.btnFindGuest);
            this.MainPanel.Controls.Add(this.btnBookings);
            this.MainPanel.Controls.Add(this.btnRooms);
            this.MainPanel.Location = new System.Drawing.Point(-1, -9);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(250, 474);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnRoomTypes);
            this.panel1.Controls.Add(this.btnMore);
            this.panel1.Location = new System.Drawing.Point(1, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 50);
            this.panel1.TabIndex = 6;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbDate.Location = new System.Drawing.Point(72, 23);
            this.lbDate.Name = "lbDate";
            this.lbDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDate.Size = new System.Drawing.Size(138, 25);
            this.lbDate.TabIndex = 81;
            this.lbDate.Text = "2024-01-30";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDate.Click += new System.EventHandler(this.lbDate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotel.Properties.Resources.hotelPicture;
            this.pictureBox1.Location = new System.Drawing.Point(377, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 288);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::hotel.Properties.Resources.hotel_building;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(-13, 10);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(87, 51);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 7;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSettings.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::hotel.Properties.Resources.Settings_30;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnSettings.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSettings.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnSettings.Location = new System.Drawing.Point(-1, 100);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(250, 50);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "        Settings";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRoomTypes
            // 
            this.btnRoomTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnRoomTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomTypes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomTypes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomTypes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoomTypes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoomTypes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnRoomTypes.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRoomTypes.ForeColor = System.Drawing.Color.White;
            this.btnRoomTypes.Image = global::hotel.Properties.Resources.room30_30;
            this.btnRoomTypes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRoomTypes.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnRoomTypes.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRoomTypes.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnRoomTypes.Location = new System.Drawing.Point(0, 50);
            this.btnRoomTypes.Name = "btnRoomTypes";
            this.btnRoomTypes.Size = new System.Drawing.Size(250, 50);
            this.btnRoomTypes.TabIndex = 6;
            this.btnRoomTypes.Text = "        Room Types";
            this.btnRoomTypes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRoomTypes.Click += new System.EventHandler(this.btnRoomTypes_Click);
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMore.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnMore.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMore.Image = global::hotel.Properties.Resources.arrow30_30;
            this.btnMore.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMore.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMore.Location = new System.Drawing.Point(-1, 0);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(250, 50);
            this.btnMore.TabIndex = 5;
            this.btnMore.Tag = "Closed";
            this.btnMore.Text = "   More";
            this.btnMore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnFindGuest
            // 
            this.btnFindGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnFindGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindGuest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindGuest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindGuest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindGuest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindGuest.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnFindGuest.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFindGuest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFindGuest.Image = global::hotel.Properties.Resources.Guest_ContextMenueStrip;
            this.btnFindGuest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindGuest.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFindGuest.Location = new System.Drawing.Point(1, 216);
            this.btnFindGuest.Name = "btnFindGuest";
            this.btnFindGuest.Size = new System.Drawing.Size(250, 50);
            this.btnFindGuest.TabIndex = 4;
            this.btnFindGuest.Text = "  Find Guest";
            this.btnFindGuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindGuest.Click += new System.EventHandler(this.btnFindGuest_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnBookings.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBookings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBookings.Image = global::hotel.Properties.Resources.Boooking30_30;
            this.btnBookings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBookings.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBookings.Location = new System.Drawing.Point(1, 161);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(250, 50);
            this.btnBookings.TabIndex = 3;
            this.btnBookings.Text = "  Bookings";
            this.btnBookings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRooms.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnRooms.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRooms.Image = global::hotel.Properties.Resources.room30_30;
            this.btnRooms.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRooms.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRooms.Location = new System.Drawing.Point(0, 110);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(250, 50);
            this.btnRooms.TabIndex = 2;
            this.btnRooms.Text = "  Rooms";
            this.btnRooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // uC_Revenue1
            // 
            this.uC_Revenue1.BackColor = System.Drawing.Color.White;
            this.uC_Revenue1.Location = new System.Drawing.Point(377, 273);
            this.uC_Revenue1.Name = "uC_Revenue1";
            this.uC_Revenue1.Size = new System.Drawing.Size(419, 106);
            this.uC_Revenue1.TabIndex = 2;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Cyan;
            this.guna2Separator1.Location = new System.Drawing.Point(10, 70);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(203, 20);
            this.guna2Separator1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 464);
            this.Controls.Add(this.uC_Revenue1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Button btnRooms;
        private Guna.UI2.WinForms.Guna2Button btnBookings;
        private Guna.UI2.WinForms.Guna2Button btnFindGuest;
        private Guna.UI2.WinForms.Guna2Button btnMore;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnRoomTypes;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private UC_Revenue uC_Revenue1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}