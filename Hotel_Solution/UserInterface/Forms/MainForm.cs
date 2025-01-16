using hotel.Properties;
using System;
using System.Windows.Forms;

namespace hotel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lbDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            Form_RoomsDetails roomsForm = new Form_RoomsDetails();
            roomsForm.ShowDialog();

        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            Form_BookingsDetails frm = new Form_BookingsDetails();
            frm.ShowDialog();
        }

        private void btnFindGuest_Click(object sender, EventArgs e)
        {
            Form_FindGuest frm = new Form_FindGuest();
            frm.ShowDialog();
        }



        private void btnMore_Click(object sender, EventArgs e)
        {
            if (btnMore.Tag.ToString() == "Closed")
            {
                panel1.Height = btnMore.Height * 3;
                btnMore.Tag = "Opened";
                btnMore.Image = Resources.arrowToDown;
                return;
            }
            panel1.Height = btnMore.Height;
            btnMore.Tag = "Closed";
            btnMore.Image = Resources.arrow30_30;
        }
        private void btnRoomTypes_Click(object sender, EventArgs e)
        {
            Form_RoomTypes frm = new Form_RoomTypes();
            frm.ShowDialog();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void lbDate_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
