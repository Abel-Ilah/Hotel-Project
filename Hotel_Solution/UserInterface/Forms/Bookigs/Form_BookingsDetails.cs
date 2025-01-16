using HotelProjectBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace hotel
{
    public partial class Form_BookingsDetails : Form
    {
        public Form_BookingsDetails()
        {
            InitializeComponent();
        }

        enum enSearchTypes {AllBookings = 1, CurrentActiveBookings = 2, BookingsWereActiveInGivenDate = 3, SearchByCheckInDate = 4, SearchByNationalNumber = 5 }
        enSearchTypes _LastSearchType = enSearchTypes.AllBookings;

        DataTable BookingsTable = new DataTable();

        int RowsPerPage = 20;
        int _PageNumber = 1;
        int PageNumber
        {
            get { return _PageNumber; }
            set { _PageNumber = value; lbPageNumber.Text = _PageNumber.ToString(); }
        }

        int TotalRowsFound = 0;
        float TotalPages = 0;

        private float CalculateTotalPages(float rowsPerPage, float totalRows)
        {
            if (RowsPerPage <= 0) rowsPerPage = 1;
            if (totalRows == 0) totalRows = 1;
            return (float)Math.Ceiling(totalRows / rowsPerPage);
        }

        private void RefreshSettingsOfPages()
        {
            PageNumber = 1;
            TotalPages = CalculateTotalPages(RowsPerPage, TotalRowsFound);
            btnNext.Enabled = (TotalPages > 1);
            btnPrev.Enabled = false;
        }

        private void LoadAllBookings()
        {
            BookingsTable = clsBooking.GetAllBookings(PageNumber, RowsPerPage, ref TotalRowsFound);
            dgvBookings.DataSource = BookingsTable.DefaultView;

        }
        private void LoadCurrentActiveBookings()
        {
            BookingsTable = clsBooking.GetActiveBookingsDetails(PageNumber, RowsPerPage, ref TotalRowsFound);
            dgvBookings.DataSource = BookingsTable.DefaultView;

        }
        private void LoadBookingsBasedOnCheckInDate()
        {
            BookingsTable = clsBooking.GetBookingsDetailsBasedOnCheckInDate(Calendar.Value, PageNumber, RowsPerPage, ref TotalRowsFound);
            dgvBookings.DataSource = BookingsTable.DefaultView;
        }
        private void LoadBookingsBasedOnNationalNumber()
        {
            BookingsTable = clsBooking.GetBookingsDetailsBasedOnNationalNumber(txtbNationalNumber.Text, PageNumber, RowsPerPage, ref TotalRowsFound);
            dgvBookings.DataSource = BookingsTable.DefaultView;

        }
        private void LoadBookingsThatWereActiveInSpecificDate()
        {
            BookingsTable = clsBooking.GetBookingsInfoThatWereActiveInASpecificDae(Calendar.Value, PageNumber, RowsPerPage, ref TotalRowsFound);
            dgvBookings.DataSource = BookingsTable.DefaultView;
        }

        private bool Date1EqualsToDate2(DateTime date1, DateTime date2)
        {
            return (date1.Year == date2.Year) && (date1.Month == date2.Month) && (date1.Day == date2.Day);
        }
        private bool Date1BiggerThanDate2(DateTime Date1, DateTime Date2)
        {
            if (Date1.Year > Date2.Year ||
            (Date1.Year == Date2.Year && Date1.Month > Date2.Month) ||
            (Date1.Year == Date2.Year && Date1.Month == Date2.Month && Date1.Day > Date2.Day))
            {
                return true;
            }
            else return false;
        }

        private void Form_BookingsDetails_Load(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex = 1; // get all bookings
            LoadCurrentActiveBookings();
            RefreshSettingsOfPages();
        }

        private void GetNextOrPrevPage()
        {
          switch (_LastSearchType)
            {
                case enSearchTypes.AllBookings:
                    LoadAllBookings();
                    break;
                case enSearchTypes.CurrentActiveBookings:
                    LoadCurrentActiveBookings();
                    break;
                case enSearchTypes.BookingsWereActiveInGivenDate:
                    LoadBookingsThatWereActiveInSpecificDate();
                    break;
                case enSearchTypes.SearchByCheckInDate:
                    LoadBookingsBasedOnCheckInDate();
                    break;
                case enSearchTypes.SearchByNationalNumber:
                    LoadBookingsBasedOnNationalNumber();
                    break;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
           PageNumber++;
           btnPrev.Enabled = true;
           GetNextOrPrevPage();
   
           if (PageNumber == TotalPages) btnNext.Enabled = false;
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
          PageNumber--;
          GetNextOrPrevPage();
          btnNext.Enabled = true;

          if (PageNumber == 1) btnPrev.Enabled = false;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFilter.SelectedItem.ToString())
            {
                case "All Bookings":
                    if (_LastSearchType != enSearchTypes.AllBookings )
                    {
                        Calendar.Visible = false;
                        txtbNationalNumber.Visible = false;
                        btnSearch.Visible = false;
                        PageNumber = 1;
                        LoadAllBookings();
                        RefreshSettingsOfPages();
                        _LastSearchType = enSearchTypes.AllBookings;
                    }
                    break;
                case "Current Active Bookings":
                    if (_LastSearchType != enSearchTypes.CurrentActiveBookings)
                    {
                        Calendar.Visible = false;
                        txtbNationalNumber.Visible = false;
                        btnSearch.Visible = false;
                        PageNumber = 1;
                        LoadCurrentActiveBookings();
                        RefreshSettingsOfPages();
                        _LastSearchType = enSearchTypes.CurrentActiveBookings;
                    }
                    break;

                case "Bookings were Active In" :
                    if (_LastSearchType != enSearchTypes.BookingsWereActiveInGivenDate)
                    {
                        Calendar.Visible = true;
                        txtbNationalNumber.Visible = false;
                        btnSearch.Visible = true;
                    }
                    break;

                case "CheckIn Date":
                    if (_LastSearchType != enSearchTypes.SearchByCheckInDate)
                    {
                        Calendar.Visible = true;
                        txtbNationalNumber.Visible = false;
                        btnSearch.Visible = true;
                    }
                    break;

                case "National Number":
                    if (_LastSearchType != enSearchTypes.SearchByNationalNumber)
                    {
                        Calendar.Visible = false;
                        txtbNationalNumber.Visible = true;
                        txtbNationalNumber.Focus();
                        btnSearch.Visible = true;
                    }
                    break;
            }
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cmbFilter.SelectedItem.ToString())
            {
                case "Bookings were Active In":
                    PageNumber = 1;
                    LoadBookingsThatWereActiveInSpecificDate();
                    RefreshSettingsOfPages();
                    _LastSearchType = enSearchTypes.BookingsWereActiveInGivenDate;
                    break;

                case "CheckIn Date":
                    PageNumber = 1;
                    LoadBookingsBasedOnCheckInDate();
                    RefreshSettingsOfPages();
                    _LastSearchType = enSearchTypes.SearchByCheckInDate;
                    break;

                case "National Number":
                    if (!string.IsNullOrEmpty(txtbNationalNumber.Text))
                    {
                     PageNumber = 1;
                     LoadBookingsBasedOnNationalNumber();
                     RefreshSettingsOfPages();
                     _LastSearchType = enSearchTypes.SearchByNationalNumber;
                    }
                    break;
            }
        }

        private void BookingsContextMenueStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BookingsContexMenueStrip.Enabled = (dgvBookings.Rows.Count > 0);
            if (!BookingsContexMenueStrip.Enabled) return;
            
            DateTime CheckInDate = Convert.ToDateTime(dgvBookings.CurrentRow.Cells["Check_In"].Value);
            DateTime CancelDate = DateTime.Now;
            CancelToolStripMenuItem.Enabled = Date1EqualsToDate2(CheckInDate, CancelDate) && dgvBookings.CurrentRow.Cells["Status"].Value.ToString() == "Active";
            CompleteToolStripMenuItem.Enabled = (dgvBookings.CurrentRow.Cells["Status"].Value.ToString() == "Active") && Date1BiggerThanDate2(DateTime.Now,CheckInDate);
        }

        private void RoomDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ShowRoomDetails frm = new Form_ShowRoomDetails(Convert.ToInt32(dgvBookings.CurrentRow.Cells["RoomID"].Value));
            frm.ShowDialog();
        }

        private void GuestDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GuestDetails frm = new Form_GuestDetails(dgvBookings.CurrentRow.Cells["N_Number"].Value.ToString());
            frm.ShowDialog();
        }

        private void CompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
         if (MessageBox.Show("are you sure you want to Complete this Booking Now ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
         {
             int BookingID = Convert.ToInt32(dgvBookings.CurrentRow.Cells["BookingID"].Value);
             int RoomID = Convert.ToInt32(dgvBookings.CurrentRow.Cells["RoomID"].Value);

             DateTime CheckInDate = Convert.ToDateTime(dgvBookings.CurrentRow.Cells["Check_In"].Value);
             DateTime InitialCheckOutDate = Convert.ToDateTime(dgvBookings.CurrentRow.Cells["Check_Out"].Value);
             DateTime ActualCheckOutDate = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,InitialCheckOutDate.Hour,InitialCheckOutDate.Minute,InitialCheckOutDate.Second);
             
             int InitialBookedDaysCount = (InitialCheckOutDate - CheckInDate).Days;
             
             decimal InitialPaidAmount = Convert.ToDecimal(dgvBookings.CurrentRow.Cells["Amount"].Value);
             decimal ActualPaidAmount = InitialPaidAmount;

             decimal RefundAmount = 0;
             decimal AdditionalAmount = 0;
             decimal PriceOfRoomPerNight = 0;

             // The visitor left before the end of the reservation.
             if (Date1BiggerThanDate2(InitialCheckOutDate, ActualCheckOutDate))
             {

                 short DaysLeft = Convert.ToInt16((InitialCheckOutDate - ActualCheckOutDate).Days);

                 PriceOfRoomPerNight = InitialPaidAmount / InitialBookedDaysCount;

                 RefundAmount = DaysLeft * PriceOfRoomPerNight;

                 ActualPaidAmount -= RefundAmount;
             }

             // The visitor left after the reservation ended by a day or more.
             if (Date1BiggerThanDate2(ActualCheckOutDate, InitialCheckOutDate))
             {

                 PriceOfRoomPerNight = InitialPaidAmount / InitialBookedDaysCount;

                 short AdditionalDays = Convert.ToInt16((ActualCheckOutDate - InitialCheckOutDate).Days);

                 AdditionalAmount = AdditionalDays * PriceOfRoomPerNight;

                 ActualPaidAmount += AdditionalAmount;
             }

             if (clsBooking.CompleteBooking(BookingID, ActualCheckOutDate, ActualPaidAmount, RoomID))
             {
               PageNumber = 1;
               LoadCurrentActiveBookings();
               RefreshSettingsOfPages();

               _LastSearchType = enSearchTypes.CurrentActiveBookings;
               Form_CompleteBookingMessage frm = new Form_CompleteBookingMessage(CheckInDate,InitialCheckOutDate,ActualCheckOutDate,InitialPaidAmount,AdditionalAmount,RefundAmount,ActualPaidAmount);
               frm.ShowDialog();

             }
          }
      
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime ActualCheckOut = Convert.ToDateTime(dgvBookings.CurrentRow.Cells["Check_Out"].Value);
            int BookingID = Convert.ToInt32(dgvBookings.CurrentRow.Cells["BookingID"].Value);
            int RoomID = Convert.ToInt32(dgvBookings.CurrentRow.Cells["RoomID"].Value);

            if (MessageBox.Show("Are You sure you want to cancel this Booking ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (clsBooking.CancelBooking(BookingID, ActualCheckOut,RoomID))
                {
                  CustomMessageBox.Caption = "Result";
                  CustomMessageBox.Text = "The Booking has been cancelled.";
                  CustomMessageBox.Show();

                  PageNumber = 1;
                  LoadCurrentActiveBookings();
                  _LastSearchType = enSearchTypes.CurrentActiveBookings;
                  RefreshSettingsOfPages();
                  
                }
            }
        }


    }
}
