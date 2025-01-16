using System;
using HotelProjectBusinessLayer;
using System.Windows.Forms;

namespace hotel
{
    public partial class Form_FindGuest : Form
    {
        public Form_FindGuest()
        {
            InitializeComponent();
        }

        private void Form_ShowBookingHistoryOfGuest_Load(object sender, EventArgs e)
        {

        }

        private void uC_GuestDetailsWithFilter1_OnGuestFound(clsGuest obj)
        {
            if (obj == null) uC_BookingHistory1.GetBookingHistory(null);
            else uC_BookingHistory1.GetBookingHistory(obj.NationalNumber);
        }
    }
}
