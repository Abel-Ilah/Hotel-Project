using HotelProjectBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class UC_BookingHistory : UserControl
    {
        DataTable BookingHistoryTable;
        public UC_BookingHistory()
        {
            InitializeComponent();
            BookingHistoryTable = new DataTable();

        }

        public void GetBookingHistory(string NationalNumber)
        {
            if (string.IsNullOrEmpty(NationalNumber))
                BookingHistoryTable.Clear();
            else
                BookingHistoryTable = clsBooking.GetShortBookingsDetailsBasedOnNationalNumber(NationalNumber);


            dgvBookings.DataSource = BookingHistoryTable.DefaultView;

        }




    }
}
