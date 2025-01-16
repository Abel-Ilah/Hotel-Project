namespace hotel
{
    partial class Form_RoomsDetails
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
            this.dgvRooms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.RoomsContexMenueStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.BookTheRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbRoomsStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbRoomsTypes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbRowsCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.RoomsContexMenueStrip.SuspendLayout();
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(1013, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(31, 29);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AllowUserToResizeColumns = false;
            this.dgvRooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRooms.ColumnHeadersHeight = 35;
            this.dgvRooms.ContextMenuStrip = this.RoomsContexMenueStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.dgvRooms.Location = new System.Drawing.Point(7, 91);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowTemplate.Height = 30;
            this.dgvRooms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRooms.Size = new System.Drawing.Size(1032, 450);
            this.dgvRooms.TabIndex = 2;
            this.dgvRooms.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen;
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRooms.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRooms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.dgvRooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.dgvRooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvRooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRooms.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvRooms.ThemeStyle.ReadOnly = true;
            this.dgvRooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            this.dgvRooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvRooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRooms.ThemeStyle.RowsStyle.Height = 30;
            this.dgvRooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            this.dgvRooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // RoomsContexMenueStrip
            // 
            this.RoomsContexMenueStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.RoomsContexMenueStrip.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.RoomsContexMenueStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookTheRoomToolStripMenuItem});
            this.RoomsContexMenueStrip.Name = "RoomsContexMenueStrip";
            this.RoomsContexMenueStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.RoomsContexMenueStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.RoomsContexMenueStrip.RenderStyle.ColorTable = null;
            this.RoomsContexMenueStrip.RenderStyle.RoundedEdges = true;
            this.RoomsContexMenueStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.RoomsContexMenueStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RoomsContexMenueStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.RoomsContexMenueStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.RoomsContexMenueStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.RoomsContexMenueStrip.Size = new System.Drawing.Size(211, 36);
            this.RoomsContexMenueStrip.Opening += new System.ComponentModel.CancelEventHandler(this.RoomsContextMenueStrip_Opening);
            // 
            // BookTheRoomToolStripMenuItem
            // 
            this.BookTheRoomToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTheRoomToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.BookTheRoomToolStripMenuItem.Image = global::hotel.Properties.Resources.booking_confirmed_ContexMinueStrip;
            this.BookTheRoomToolStripMenuItem.Name = "BookTheRoomToolStripMenuItem";
            this.BookTheRoomToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.BookTheRoomToolStripMenuItem.Text = "   Book The Room";
            this.BookTheRoomToolStripMenuItem.Click += new System.EventHandler(this.bookTheRoomToolStripMenuItem_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.cmbRoomsStatus);
            this.guna2Panel1.Controls.Add(this.cmbRoomsTypes);
            this.guna2Panel1.Location = new System.Drawing.Point(7, 41);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1027, 44);
            this.guna2Panel1.TabIndex = 5;
            // 
            // cmbRoomsStatus
            // 
            this.cmbRoomsStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoomsStatus.BorderRadius = 15;
            this.cmbRoomsStatus.BorderThickness = 2;
            this.cmbRoomsStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoomsStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomsStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoomsStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoomsStatus.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmbRoomsStatus.ForeColor = System.Drawing.Color.Gray;
            this.cmbRoomsStatus.ItemHeight = 30;
            this.cmbRoomsStatus.Items.AddRange(new object[] {
            "All Status",
            "Available",
            "Booked"});
            this.cmbRoomsStatus.Location = new System.Drawing.Point(300, 5);
            this.cmbRoomsStatus.Name = "cmbRoomsStatus";
            this.cmbRoomsStatus.Size = new System.Drawing.Size(182, 36);
            this.cmbRoomsStatus.TabIndex = 84;
            this.cmbRoomsStatus.SelectedIndexChanged += new System.EventHandler(this.cmbRoomsStatus_SelectedIndexChanged);
            // 
            // cmbRoomsTypes
            // 
            this.cmbRoomsTypes.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoomsTypes.BorderRadius = 15;
            this.cmbRoomsTypes.BorderThickness = 2;
            this.cmbRoomsTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoomsTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomsTypes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoomsTypes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoomsTypes.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmbRoomsTypes.ForeColor = System.Drawing.Color.Gray;
            this.cmbRoomsTypes.ItemHeight = 30;
            this.cmbRoomsTypes.Items.AddRange(new object[] {
            "All Rooms",
            "Single Room",
            "Double Room",
            "Twin Room",
            "Normal Family Room",
            "Large Family Room"});
            this.cmbRoomsTypes.Location = new System.Drawing.Point(2, 4);
            this.cmbRoomsTypes.Name = "cmbRoomsTypes";
            this.cmbRoomsTypes.Size = new System.Drawing.Size(292, 36);
            this.cmbRoomsTypes.TabIndex = 80;
            this.cmbRoomsTypes.SelectedIndexChanged += new System.EventHandler(this.cmbRoomsTypes_SelectedIndexChanged);
            // 
            // lbRowsCount
            // 
            this.lbRowsCount.BackColor = System.Drawing.Color.Teal;
            this.lbRowsCount.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRowsCount.ForeColor = System.Drawing.Color.White;
            this.lbRowsCount.Location = new System.Drawing.Point(7, 544);
            this.lbRowsCount.Name = "lbRowsCount";
            this.lbRowsCount.Size = new System.Drawing.Size(1032, 25);
            this.lbRowsCount.TabIndex = 7;
            this.lbRowsCount.Text = "Records : 20";
            this.lbRowsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_RoomsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 570);
            this.Controls.Add(this.lbRowsCount);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_RoomsDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvailableRooms";
            this.Load += new System.EventHandler(this.AvailableRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.RoomsContexMenueStrip.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRooms;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip RoomsContexMenueStrip;
        private System.Windows.Forms.ToolStripMenuItem BookTheRoomToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRoomsTypes;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRoomsStatus;
        private System.Windows.Forms.Label lbRowsCount;
    }
}