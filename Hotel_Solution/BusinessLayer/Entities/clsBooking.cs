using HotelProjectDataAccessLayer;
using System;
using System.Data;

namespace HotelProjectBusinessLayer
{
    public class clsBooking
    {
        public int BookingID { get; set; }
        public int RoomID { get; set; }
        public int GuestID { get; set; }
        public byte NumberOfPeople { get; set; }       
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public float PaidAmount { get; set; }

        public enum enBookingsStatus {Active = 0,Canceled = 1,Completed = 2 };
        public enBookingsStatus BookingStatus { get; set; }

        public enum enModes { AddNew = 1, Update = 2 }
        public enModes Mode;

        public clsBooking()
        {
          BookingID = -1;
          RoomID = -1;
          GuestID = -1;
          NumberOfPeople = 0;
          PaidAmount = -1;
          BookingStatus = enBookingsStatus.Active;
          Mode = enModes.AddNew;
        }

        private clsBooking(int bookingID, int roomID, int guestID, byte numberOfPeople, DateTime checkIn, DateTime checkOut, float paidAmount, enBookingsStatus bookingStatus)
        {
            BookingID = bookingID;
            RoomID = roomID;
            GuestID = guestID;
            NumberOfPeople = numberOfPeople;
            CheckIn = checkIn;
            CheckOut = checkOut;
            PaidAmount = paidAmount;
            BookingStatus = bookingStatus;
            Mode = enModes.Update;
        }
    
        private bool _AddNewBooking()
        {
            BookingID = clsBookingDataAccessLayer.AddNewBooking(RoomID, GuestID,NumberOfPeople,CheckIn,CheckOut,PaidAmount,(byte)BookingStatus);
            return BookingID > -1;
        }
        private bool _UpdateBooking()
        {
            return true;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enModes.AddNew:
                    if (_AddNewBooking())
                    {
                        Mode = enModes.Update;
                        return true;
                    }
                    break;
                case enModes.Update:
                    return _UpdateBooking();
            }
            return false;
        }

        public static bool CompleteBooking(int BookingID, DateTime ActualCheckOut, decimal ActualPaidAmount, int RoomID)
        {
            return clsBookingDataAccessLayer.UpdateBookingStatus(BookingID,ActualCheckOut,ActualPaidAmount, Convert.ToByte(enBookingsStatus.Completed), RoomID);
        }
        public static bool CancelBooking(int BookingID, DateTime ActualCheckOut, int RoomID)
        {
            return clsBookingDataAccessLayer.UpdateBookingStatus(BookingID,ActualCheckOut,0, Convert.ToByte(enBookingsStatus.Canceled), RoomID);
        }

        public static DataTable GetBookingsInfoThatWereActiveInASpecificDae(DateTime Date, int PageNumber, int RowsPerPage, ref int TotalRows)
        {
            return clsBookingDataAccessLayer.GetBookingsInfoThatWereActiveInASpecificDae(Date, PageNumber, RowsPerPage, ref TotalRows);
        }
        public static DataTable GetBookingsDetailsBasedOnCheckInDate(DateTime CheckInDate, int PageNumber, int RowsPerPage,ref int TotalRows)
        {
            return clsBookingDataAccessLayer.GetBookingsInfoBasedOnCheckInDate(CheckInDate, PageNumber, RowsPerPage,ref TotalRows);
        }
        public static DataTable GetBookingsDetailsBasedOnNationalNumber(string NationalNumber, int PageNumber, int RowsPerPage, ref int TotalRows)
        {
            return clsBookingDataAccessLayer.GetBookingsInfoBasedOnNationalNumber(NationalNumber, PageNumber, RowsPerPage, ref TotalRows);
        }
        public static DataTable GetActiveBookingsDetails(int PageNumber, int RowsPerPage,ref int TotalRows)
        {
            return clsBookingDataAccessLayer.GetActiveBookingsInfo(PageNumber, RowsPerPage, ref TotalRows);
        }
        public static DataTable GetAllBookings(int PageNumber, int RowsPerPage, ref int TotalRows)
        {
            return clsBookingDataAccessLayer.GetAllBookings(PageNumber, RowsPerPage, ref TotalRows);
        }
        public static DataTable GetShortBookingsDetailsBasedOnNationalNumber(string NationalNumber)
        {
            return clsBookingDataAccessLayer.GetShortBookingsInfoBasedOnNationalNumber(NationalNumber);
        }
       
  
    }
}
