namespace hotel
{
    partial class Form_BookingsDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dgvBookings = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BookingsContexMenueStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.RoomDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuestDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Calendar = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtbNationalNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.lbPageNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label13 = new System.Windows.Forms.Label();
            this.CustomMessageBox = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.BookingsContexMenueStrip.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(997, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(31, 29);
            this.guna2ControlBox1.TabIndex = 2;
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
            this.dgvBookings.ContextMenuStrip = this.BookingsContexMenueStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookings.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.dgvBookings.Location = new System.Drawing.Point(1, 95);
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
            this.dgvBookings.Size = new System.Drawing.Size(1027, 467);
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
            // BookingsContexMenueStrip
            // 
            this.BookingsContexMenueStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.BookingsContexMenueStrip.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.BookingsContexMenueStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RoomDetailsToolStripMenuItem,
            this.GuestDetailsToolStripMenuItem,
            this.CompleteToolStripMenuItem,
            this.CancelToolStripMenuItem});
            this.BookingsContexMenueStrip.Name = "RoomsContexMenueStrip";
            this.BookingsContexMenueStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BookingsContexMenueStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.BookingsContexMenueStrip.RenderStyle.ColorTable = null;
            this.BookingsContexMenueStrip.RenderStyle.RoundedEdges = true;
            this.BookingsContexMenueStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.BookingsContexMenueStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BookingsContexMenueStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.BookingsContexMenueStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.BookingsContexMenueStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.BookingsContexMenueStrip.Size = new System.Drawing.Size(197, 132);
            this.BookingsContexMenueStrip.Opening += new System.ComponentModel.CancelEventHandler(this.BookingsContextMenueStrip_Opening);
            // 
            // RoomDetailsToolStripMenuItem
            // 
            this.RoomDetailsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.RoomDetailsToolStripMenuItem.Image = global::hotel.Properties.Resources.room30_30;
            this.RoomDetailsToolStripMenuItem.Name = "RoomDetailsToolStripMenuItem";
            this.RoomDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.RoomDetailsToolStripMenuItem.Text = "   Room Details";
            this.RoomDetailsToolStripMenuItem.Click += new System.EventHandler(this.RoomDetailsToolStripMenuItem_Click);
            // 
            // GuestDetailsToolStripMenuItem
            // 
            this.GuestDetailsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.GuestDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.GuestDetailsToolStripMenuItem.Image = global::hotel.Properties.Resources.Guest_ContextMenueStrip;
            this.GuestDetailsToolStripMenuItem.Name = "GuestDetailsToolStripMenuItem";
            this.GuestDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.GuestDetailsToolStripMenuItem.Text = "   Guest Details";
            this.GuestDetailsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuestDetailsToolStripMenuItem.Click += new System.EventHandler(this.GuestDetailsToolStripMenuItem_Click);
            // 
            // CompleteToolStripMenuItem
            // 
            this.CompleteToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CompleteToolStripMenuItem.Image = global::hotel.Properties.Resources.booking_confirmed_ContexMinueStrip;
            this.CompleteToolStripMenuItem.Name = "CompleteToolStripMenuItem";
            this.CompleteToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.CompleteToolStripMenuItem.Text = "   Complete";
            this.CompleteToolStripMenuItem.Click += new System.EventHandler(this.CompleteToolStripMenuItem_Click);
            // 
            // CancelToolStripMenuItem
            // 
            this.CancelToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CancelToolStripMenuItem.Image = global::hotel.Properties.Resources.booking_Canceled_ContextMinueStrip;
            this.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            this.CancelToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.CancelToolStripMenuItem.Text = "   Cancel";
            this.CancelToolStripMenuItem.Click += new System.EventHandler(this.CancelToolStripMenuItem_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.Calendar);
            this.guna2Panel1.Controls.Add(this.btnSearch);
            this.guna2Panel1.Controls.Add(this.txtbNationalNumber);
            this.guna2Panel1.Controls.Add(this.cmbFilter);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 45);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1027, 44);
            this.guna2Panel1.TabIndex = 4;
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.Color.Transparent;
            this.Calendar.BorderRadius = 15;
            this.Calendar.Checked = true;
            this.Calendar.FillColor = System.Drawing.Color.White;
            this.Calendar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Calendar.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Calendar.Location = new System.Drawing.Point(304, 4);
            this.Calendar.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Calendar.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(332, 36);
            this.Calendar.TabIndex = 89;
            this.Calendar.Value = new System.DateTime(2024, 9, 26, 14, 40, 34, 243);
            this.Calendar.Visible = false;
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
            this.btnSearch.Location = new System.Drawing.Point(646, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 83;
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtbNationalNumber
            // 
            this.txtbNationalNumber.AutoRoundedCorners = true;
            this.txtbNationalNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtbNationalNumber.BorderRadius = 17;
            this.txtbNationalNumber.BorderThickness = 3;
            this.txtbNationalNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbNationalNumber.DefaultText = "";
            this.txtbNationalNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbNationalNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbNationalNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbNationalNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbNationalNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbNationalNumber.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Bold);
            this.txtbNationalNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtbNationalNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbNationalNumber.Location = new System.Drawing.Point(301, 3);
            this.txtbNationalNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNationalNumber.MaxLength = 30;
            this.txtbNationalNumber.Name = "txtbNationalNumber";
            this.txtbNationalNumber.PasswordChar = '\0';
            this.txtbNationalNumber.PlaceholderText = "";
            this.txtbNationalNumber.SelectedText = "";
            this.txtbNationalNumber.Size = new System.Drawing.Size(334, 37);
            this.txtbNationalNumber.TabIndex = 81;
            this.txtbNationalNumber.Visible = false;
            // 
            // cmbFilter
            // 
            this.cmbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilter.BorderRadius = 15;
            this.cmbFilter.BorderThickness = 2;
            this.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilter.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmbFilter.ForeColor = System.Drawing.Color.Gray;
            this.cmbFilter.ItemHeight = 30;
            this.cmbFilter.Items.AddRange(new object[] {
            "All Bookings",
            "Current Active Bookings",
            "Bookings were Active In",
            "CheckIn Date",
            "National Number"});
            this.cmbFilter.Location = new System.Drawing.Point(2, 4);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(292, 36);
            this.cmbFilter.TabIndex = 80;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.BorderColor = System.Drawing.Color.Teal;
            this.btnNext.BorderThickness = 1;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Enabled = false;
            this.btnNext.FillColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.Teal;
            this.btnNext.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.White;
            this.btnNext.ImageSize = new System.Drawing.Size(32, 32);
            this.btnNext.Location = new System.Drawing.Point(598, 567);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNext.Size = new System.Drawing.Size(105, 33);
            this.btnNext.TabIndex = 64;
            this.btnNext.Text = "Next >>";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.BorderColor = System.Drawing.Color.Teal;
            this.btnPrev.BorderThickness = 1;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.FillColor = System.Drawing.Color.White;
            this.btnPrev.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.Teal;
            this.btnPrev.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnPrev.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPrev.ImageSize = new System.Drawing.Size(32, 32);
            this.btnPrev.Location = new System.Drawing.Point(368, 567);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPrev.Size = new System.Drawing.Size(105, 33);
            this.btnPrev.TabIndex = 65;
            this.btnPrev.Text = "<< Prev";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lbPageNumber
            // 
            this.lbPageNumber.AutoSize = false;
            this.lbPageNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbPageNumber.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageNumber.ForeColor = System.Drawing.Color.Red;
            this.lbPageNumber.Location = new System.Drawing.Point(484, 568);
            this.lbPageNumber.Name = "lbPageNumber";
            this.lbPageNumber.Size = new System.Drawing.Size(104, 32);
            this.lbPageNumber.TabIndex = 66;
            this.lbPageNumber.Text = "1";
            this.lbPageNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(5, 30);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1022, 10);
            this.guna2Separator1.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Algerian", 16F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(-1, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 25);
            this.label13.TabIndex = 73;
            this.label13.Text = "Manage Bookings";
            // 
            // CustomMessageBox
            // 
            this.CustomMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.CustomMessageBox.Caption = null;
            this.CustomMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.CustomMessageBox.Parent = this;
            this.CustomMessageBox.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.CustomMessageBox.Text = null;
            // 
            // Form_BookingsDetails
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 604);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbPageNumber);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvBookings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_BookingsDetails";
            this.Text = "Form_BookingsDetails";
            this.Load += new System.EventHandler(this.Form_BookingsDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.BookingsContexMenueStrip.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBookings;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtbNationalNumber;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilter;
        public Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker Calendar;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPageNumber;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip BookingsContexMenueStrip;
        private System.Windows.Forms.ToolStripMenuItem CompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuestDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoomDetailsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2MessageDialog CustomMessageBox;
    }
}