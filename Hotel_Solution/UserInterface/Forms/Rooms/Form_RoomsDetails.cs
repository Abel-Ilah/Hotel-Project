using HotelProjectBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace hotel
{
    public partial class Form_RoomsDetails : Form
    {
        DataTable RoomsTable = new DataTable();

        public Form_RoomsDetails()
        {
            InitializeComponent();
        }

        private void LoadRoomsDetails()
        {
            RoomsTable = clsRoom.GetAllRooms();
            dgvRooms.DataSource = RoomsTable.DefaultView;
            lbRowsCount.Text = $"Records : {RoomsTable.DefaultView.Count}";
        }

        string RoomsTypesFilter(string RoomType)
        {
            string Filter = string.Empty;

            if (RoomType == "All Rooms")
                return $"1 = 1";// return all Room Types

            return $"Type = '{RoomType}' ";
        }
        string StatusFilter (string Status)
        {
            string Filter = string.Empty;

            if (Status == "All Status")
                return $"1 = 1"; // return all status

            return $"Status = '{Status}' ";
        }
        string Filter (string RoomType, string status)
        {
            return $"{RoomsTypesFilter(RoomType)} AND {StatusFilter(status)}";
        }
        private void FilterRoomsTable()
        {
           if ( cmbRoomsTypes.SelectedItem == null || cmbRoomsStatus.SelectedItem == null) return;
          
            RoomsTable.DefaultView.RowFilter = Filter(cmbRoomsTypes.SelectedItem.ToString(), cmbRoomsStatus.SelectedItem.ToString());
            dgvRooms.DataSource = RoomsTable.DefaultView;
            lbRowsCount.Text = $"Records : {RoomsTable.DefaultView.Count}";
        }
        private void InitializeDataGridViewWithSettings()
        {
            LoadRoomsDetails();
            if (dgvRooms.Columns.Count == 7)
            {
                dgvRooms.Columns[0].Width = 80;
                dgvRooms.Columns[1].Width = 180;
                dgvRooms.Columns[2].Width = 420;
                dgvRooms.Columns[4].Width = 60;
            }
        }

        private void AvailableRooms_Load(object sender, EventArgs e)
        {
            InitializeDataGridViewWithSettings();
            cmbRoomsTypes.SelectedIndex = 0;
            cmbRoomsStatus.SelectedIndex = 0;
        }

        private void bookTheRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddNewBooking NewBookingForm = new Form_AddNewBooking(Convert.ToInt32(dgvRooms.CurrentRow.Cells["RoomID"].Value));
            NewBookingForm.WhenRoomIsBooked += LoadRoomsDetails;
            NewBookingForm.ShowDialog();
        }

        private void RoomsContextMenueStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            RoomsContexMenueStrip.Enabled = (dgvRooms.RowCount > 0);

            if (!RoomsContexMenueStrip.Enabled) return;

            BookTheRoomToolStripMenuItem.Enabled = (dgvRooms.CurrentRow.Cells["Status"].Value.ToString()== "Available");
        }

        private void cmbRoomsTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterRoomsTable();
        }

        private void cmbRoomsStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterRoomsTable();
        }

      
    }
}
