using HotelProjectBusinessLayer;
using System;

using System.Windows.Forms;

namespace hotel
{
    public partial class UC_GuestDetailsWithFilter : UserControl
    {

        // event declaration :
        public event Action<clsGuest> OnGuestFound;

        public void GuestIsFound(clsGuest FoundGuest)
        {
            OnGuestFound?.Invoke(FoundGuest);
        }

        private string NationalNumber = string.Empty;
      

        public UC_GuestDetailsWithFilter()
        {
            InitializeComponent();
            txtbSearch.ContextMenuStrip = new ContextMenuStrip();
            cmbFilter.SelectedIndex = 0;
            txtbSearch.Focus();
        }
     
       
        private void txtbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cmbFilter.SelectedItem)
            {
                case  "National Number" :
                    if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ')
                    {
                        e.Handled = true;
                    }
                 break;
                case "Passport Number":
                    if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ')
                    {
                        e.Handled = true;
                    }
                 break;
            }
            
        }

        private void txtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                Search(txtbSearch.Text);
            }
        }
        public void Search(string Text)
        {
            if (string.IsNullOrEmpty(Text)) return;

            switch (cmbFilter.SelectedItem)
            {
                case "National Number":
                    uC_GuestDetails1.LoadGuestInfoUsingNationalNumber(Text);
                    break;
                case "Passport Number":
                    uC_GuestDetails1.LoadGuestInfoUsingPassportNumber(Text);
                    break;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
          Search(txtbSearch.Text);
        }

        private void uC_GuestDetails1_OnGuestFound(clsGuest obj)
        {
            GuestIsFound(obj);
        }

        private void GetNationalNumberOfNewAddedGuest(string nationalNumber)
        {
            NationalNumber = nationalNumber;

            if (string.IsNullOrEmpty(NationalNumber)) return;

            cmbFilter.SelectedIndex = 0;// selected item is National Number.
            txtbSearch.Text = NationalNumber;
            uC_GuestDetails1.LoadGuestInfoUsingNationalNumber(NationalNumber);
        }
        private void btnAddNewGuest_Click(object sender, EventArgs e)
        {
            Form_AddOrUpdateGuest frm = new Form_AddOrUpdateGuest(null);
            frm.OnGuestDataChanged += GetNationalNumberOfNewAddedGuest;
            frm.ShowDialog();

        }
    }
}
