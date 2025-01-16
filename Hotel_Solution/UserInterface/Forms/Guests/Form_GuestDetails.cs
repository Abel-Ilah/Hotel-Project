using System;
using System.Windows.Forms;
using HotelProjectBusinessLayer;
namespace hotel
{
    public partial class Form_GuestDetails : Form
    {
        string NationalNumber;
        public Form_GuestDetails(string nationalNumber)
        {
            InitializeComponent();
            NationalNumber=nationalNumber;
        }
     
        private void Form_GuestDetails_Load(object sender, EventArgs e)
        {
            uC_GuestDetails1.LoadGuestInfoUsingNationalNumber(NationalNumber);
        }

        private void uC_GuestDetails1_OnGuestFound(clsGuest obj)
        {
            if (obj == null) uC_BookingHistory1.GetBookingHistory(null);
            else uC_BookingHistory1.GetBookingHistory(obj.NationalNumber);
        }
    }
}
