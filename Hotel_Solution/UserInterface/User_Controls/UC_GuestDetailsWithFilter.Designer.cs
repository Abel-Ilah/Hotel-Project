namespace hotel
{
    partial class UC_GuestDetailsWithFilter
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
            this.uC_GuestDetails1 = new hotel.UC_GuestDetails();
            this.btnAddNewGuest = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // uC_GuestDetails1
            // 
            this.uC_GuestDetails1.BackColor = System.Drawing.Color.White;
            this.uC_GuestDetails1.Location = new System.Drawing.Point(0, 47);
            this.uC_GuestDetails1.Name = "uC_GuestDetails1";
            this.uC_GuestDetails1.Size = new System.Drawing.Size(730, 262);
            this.uC_GuestDetails1.TabIndex = 83;
            this.uC_GuestDetails1.OnGuestFound += new System.Action<HotelProjectBusinessLayer.clsGuest>(this.uC_GuestDetails1_OnGuestFound);
            // 
            // btnAddNewGuest
            // 
            this.btnAddNewGuest.BackColor = System.Drawing.Color.White;
            this.btnAddNewGuest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddNewGuest.BorderRadius = 20;
            this.btnAddNewGuest.BorderThickness = 2;
            this.btnAddNewGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewGuest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewGuest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewGuest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewGuest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewGuest.FillColor = System.Drawing.Color.White;
            this.btnAddNewGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAddNewGuest.ForeColor = System.Drawing.Color.Gray;
            this.btnAddNewGuest.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnAddNewGuest.Image = global::hotel.Properties.Resources.Add_Person_72;
            this.btnAddNewGuest.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnAddNewGuest.ImageSize = new System.Drawing.Size(37, 37);
            this.btnAddNewGuest.Location = new System.Drawing.Point(668, 1);
            this.btnAddNewGuest.Name = "btnAddNewGuest";
            this.btnAddNewGuest.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddNewGuest.Size = new System.Drawing.Size(45, 45);
            this.btnAddNewGuest.TabIndex = 3;
            this.btnAddNewGuest.Click += new System.EventHandler(this.btnAddNewGuest_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 30;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::hotel.Properties.Resources.search2;
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.Location = new System.Drawing.Point(625, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtbSearch
            // 
            this.txtbSearch.AutoRoundedCorners = true;
            this.txtbSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtbSearch.BorderRadius = 17;
            this.txtbSearch.BorderThickness = 3;
            this.txtbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbSearch.DefaultText = "";
            this.txtbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.txtbSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSearch.Location = new System.Drawing.Point(284, 5);
            this.txtbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtbSearch.MaxLength = 45;
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.PasswordChar = '\0';
            this.txtbSearch.PlaceholderText = "";
            this.txtbSearch.SelectedText = "";
            this.txtbSearch.Size = new System.Drawing.Size(380, 37);
            this.txtbSearch.TabIndex = 1;
            this.txtbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbSearch_KeyDown);
            this.txtbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbSearch_KeyPress);
            // 
            // cmbFilter
            // 
            this.cmbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilter.BorderRadius = 15;
            this.cmbFilter.BorderThickness = 3;
            this.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.cmbFilter.ForeColor = System.Drawing.Color.Gray;
            this.cmbFilter.ItemHeight = 30;
            this.cmbFilter.Items.AddRange(new object[] {
            "National Number",
            "Passport Number"});
            this.cmbFilter.Location = new System.Drawing.Point(3, 5);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(260, 36);
            this.cmbFilter.TabIndex = 4;
            // 
            // UC_GuestDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnAddNewGuest);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbSearch);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.uC_GuestDetails1);
            this.Name = "UC_GuestDetailsWithFilter";
            this.Size = new System.Drawing.Size(730, 307);
            this.ResumeLayout(false);

        }

        #endregion
        private UC_GuestDetails uC_GuestDetails1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewGuest;
        public Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtbSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilter;
    }
}
