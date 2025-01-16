
using Guna.UI2.WinForms;

using System;
using System.Windows.Forms;
using HotelProjectBusinessLayer;
namespace hotel
{
    public partial class Form_AddNewBooking : Form
    {

      public Action WhenRoomIsBooked;
      
      int RoomID;
      bool TheRoomIsBookedSuccessfully = false;

      private float _BookingAmount = 0;
      float BookingAmount
      {
          get { return _BookingAmount; }
          set
          {
              _BookingAmount = value;
              lbBookingAmount.Text = _BookingAmount.ToString();
          }
      }


      clsRoom Room;
      clsBooking Booking;
      clsRoomType RoomType;
      //clsServiceWithBooking BreakfastService;
      public Form_AddNewBooking(int roomId)
      {
       InitializeComponent();
       RoomID = roomId;
      }

       void FillComboBoxWithNumbersBasedOnRoomCapacity(byte RoomCapacity)
        {
          
         for (byte i = 1; i <= RoomCapacity; i++)
         {
          cmbNumberOfGuests.Items.Add(i);
         }
         cmbNumberOfGuests.SelectedIndex = 0;
        }
       private void Add_Update_Booking_form_Load(object sender, EventArgs e)
        {
         lbCheckIn.Text=DateTime.Now.ToShortDateString();

          Booking = new clsBooking();
          
          Room = clsRoom.Find(RoomID);
          if (Room!=null)
          {
              lbRoomNumber.Text = Room.RoomNumber.ToString();
              lbRoomFloor.Text = Room.FloorNumber.ToString();
              
              RoomType = clsRoomType.Find(Room.RoomTypeID);
              if (RoomType!=null)
              {
                 lbRoomTypeName.Text = RoomType.RoomTypeName;
                 lbRoomPrice.Text = RoomType.PricePerNight.ToString();

                 FillComboBoxWithNumbersBasedOnRoomCapacity(RoomType.Capacity);

                 Calendar.MinDate = DateTime.Now.AddDays(1);

                 BookingAmount = 0;
              }
          }
        
        }

     
       private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       private void uC_GuestDetailsWithFilter1_OnGuestFound(clsGuest obj)
        {
            if (obj==null)
            {
                gbBookingDetails.Enabled = false;
                btnSave.Enabled=false;
                BookingAmount = 0;
            }
            else
            {
                gbBookingDetails.Enabled = true;
                btnSave.Enabled= true;
                if (Booking.Mode==clsBooking.enModes.AddNew)
                {
                    Booking.GuestID = obj.GuestID;
                }
                CalculateBookingRoomPrice();
            }
        }

       private void CalculateBookingRoomPrice()
       {
            DateTime CheckInDate = DateTime.Now.Date;

            DateTime CheckOutDate = Calendar.Value.Date;

            short BookingDays = Convert.ToInt16((CheckOutDate - CheckInDate).Days);

            BookingAmount = RoomType.PricePerNight * BookingDays;

       }
        
       void ShowMessage(string Text,string Caption, MessageDialogButtons button,MessageDialogIcon icon)
       {
            CustomMessageBox.Text=Text;
            CustomMessageBox.Caption=Caption;
            CustomMessageBox.Buttons=button;
            CustomMessageBox.Icon=icon;
            CustomMessageBox.Show();
       }
        bool SaveBooking()
        {
          if (Booking.Mode == clsBooking.enModes.AddNew)
          {
            Booking.RoomID = RoomID;
            Booking.CheckIn = DateTime.Now.Date;
            Booking.BookingStatus = clsBooking.enBookingsStatus.Active;
          }
          Booking.NumberOfPeople = Convert.ToByte(cmbNumberOfGuests.SelectedItem);
          Booking.CheckOut = Calendar.Value;
          Booking.PaidAmount = BookingAmount;
          return Booking.Save();
        }
       private void btnSave_Click(object sender, EventArgs e)
       { if (TheRoomIsBookedSuccessfully) return;

         if (SaveBooking())
         {
            lbBookingID.Text = Booking.BookingID.ToString();
            
            ShowMessage("Booking Saved Successfully", "Save Result",MessageDialogButtons.OK, MessageDialogIcon.Information);

            TheRoomIsBookedSuccessfully = true;
            uC_GuestDetailsWithFilter1.Enabled = false;
            gbBookingDetails.Enabled = false;
            btnSave.Enabled = false;

            WhenRoomIsBooked?.Invoke();
         }
         else { ShowMessage("Operation Failed while saving the booking info", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error); }

       }

        private void Calendar_ValueChanged(object sender, EventArgs e)
        {
            CalculateBookingRoomPrice();
        }
    }
}
