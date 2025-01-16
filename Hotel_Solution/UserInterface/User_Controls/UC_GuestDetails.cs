using hotel.Properties;
using HotelProjectBusinessLayer;
using System;

using System.Windows.Forms;

namespace hotel
{
    public partial class UC_GuestDetails : UserControl
    {
       
        // eventArgs e :
        private class GuestEventArgs : EventArgs
        {
            public clsGuest FoundGuest { get; }

            public GuestEventArgs(clsGuest guest)
            {
                FoundGuest = guest;
            }
        }

        // event declaration :
        public event Action<clsGuest> OnGuestFound;

        public void GuestIsFound()
        {
            OnGuestFound?.Invoke(Guest);
        }
        public void GuestNotFound()
        {
            OnGuestFound?.Invoke(null);
        }

        clsGuest Guest = null;
        public UC_GuestDetails()
        {
            InitializeComponent();
           
        }

       private void ResetGuestCard()
        {
          lbFullName.Text = "FullName";
          lbGuestID.Text = "[#####]";
          lbNationalNumber.Text = "[#####]";
          lbPhone.Text = "[#####]";
          lbCountry.Text = "[#####]";
          lbPassportNumber.Text = "[#####]";
          lbExpirationDate.Text = "[#####]";
          lbIssueIn.Text = "[#####]";
          pbGender.Image = Resources.Male;
        }
       private void FillCardWithGuestInfo(clsGuest guest)
       {
            ResetGuestCard();
            btnUpdate.Enabled = (guest != null);
            if (Guest == null)
            {
              GuestNotFound();
              MessageBox_GuestNotFound.Parent = ParentForm;
              MessageBox_GuestNotFound.Text = "Guest Not Found !";
              MessageBox_GuestNotFound.Caption = "Error";
              MessageBox_GuestNotFound.Show();
              return;
            }
            GuestIsFound();
            lbFullName.Text = guest.FullName;
            lbGuestID.Text = guest.GuestID.ToString();
            lbNationalNumber.Text= guest.NationalNumber;
            lbPhone.Text= guest.Phone;
            lbCountry.Text = clsCountry.GetCountryName(guest.Nationality); // you have to put here the countryName.

            if (!string.IsNullOrEmpty(guest.PassportNumber))
                lbPassportNumber.Text = guest.PassportNumber;
            else lbPassportNumber.Text = "[#####]";

            if (guest.PassportExpirationDate.HasValue)
                lbExpirationDate.Text = guest.PassportExpirationDate.Value.ToShortDateString();
            else lbExpirationDate.Text = "[#####]";

            if (guest.CountryOfIssue.HasValue)
                lbIssueIn.Text = clsCountry.GetCountryName(guest.CountryOfIssue.Value);// you have to put here the countryName.
            else lbIssueIn.Text = "[#####]";

            pbGender.Image = (guest.Gender==clsPerson.enGenders.Male)? Resources.Male: Resources.female;

        }
       public void LoadGuestInfoUsingNationalNumber(string NationalNumber) 
       {
         
          Guest = clsGuest.FindByNationalNumber(NationalNumber);
         
          FillCardWithGuestInfo(Guest);
         
       }
       public void LoadGuestInfoUsingPassportNumber(string PassportNumber)
       {
           Guest = clsGuest.FindByPassportNumber(PassportNumber);

           FillCardWithGuestInfo(Guest);

       }

        private void gbPassPortInof_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form_AddOrUpdateGuest frm = new Form_AddOrUpdateGuest(Guest.GuestID);
            frm.OnGuestDataChanged += LoadGuestInfoUsingNationalNumber;
            frm.ShowDialog();

        }

        private void UC_GuestDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
