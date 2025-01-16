using hotel.Properties;
using HotelProjectBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;


namespace hotel
{
    public partial class Form_AddOrUpdateGuest : Form
    {

        public  Action<string> OnGuestDataChanged;

        private void GuestDataChanged(string NationalNumber)
        {
           OnGuestDataChanged?.Invoke(NationalNumber);
        }

        DataTable Countries =new DataTable();
        int? GuestID= null;
        clsGuest Guest;
        public Form_AddOrUpdateGuest(int? GuestId)
        {
            InitializeComponent();
            GuestID=GuestId;
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }
      
        private void txtbNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void txtbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
        private void txtbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtbPassportNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FillComboBoxesWithCountries()
        {
            Countries = clsCountry.GetAllCountries();
    
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Countries;

            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = Countries;

            cmbCountries.DataSource = bindingSource1;
            cmbCountries.DisplayMember = "CountryName";
            cmbCountries.ValueMember = "CountryID";
            cmbCountries.SelectedValue = GetCountryID("Morocco");

            cmbCountries2.DataSource = bindingSource2;
            cmbCountries2.DisplayMember = "CountryName";
            cmbCountries2.ValueMember = "CountryID";
            cmbCountries2.SelectedValue = GetCountryID("Morocco");
        }
        private int GetCountryID(string CountryName)
        {
            int countryID = 1;
            DataRow[] rows = Countries.Select($"CountryName = '{CountryName}'");
            if (rows.Length > 0)
            {
                countryID = (int)rows[0]["CountryID"];
            }
            return countryID;
        }
        private void Add_Update_Guest_Form_Load(object sender, EventArgs e)
        {
            FillComboBoxesWithCountries();
            if (GuestID==null)
            {
                rbMale.Checked = true;
                Guest = new clsGuest();
                pbAddOrUpdateGuest.Image = Resources.addPerson;
                return;
            }
            Guest = clsGuest.FindByGuestID(GuestID.Value);
            if (Guest==null)
            {
                CustomMessageBox.Text = "Guest Not Found!";
                CustomMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                CustomMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                CustomMessageBox.Caption = "Error";
                CustomMessageBox.Show();
                Close();
                return;
            }
            pbAddOrUpdateGuest.Image = Resources.updatePerson;

            lbGuestID.Text = Guest.GuestID.ToString();
            txtbFirstName.Text = Guest.FirstName;
            txtbLastName.Text = Guest.LastName;
            txtbNationalNumber.Text= Guest.NationalNumber;
            txtbPhone.Text = Guest.Phone;
            cmbCountries.SelectedValue = Guest.Nationality;

            if (Guest.Gender == clsGuest.enGenders.Male)
                  rbMale.Checked = true;
            else  rbFemale.Checked = true;

            if (!string.IsNullOrEmpty(Guest.PassportNumber))
            {
                txtbPassportNumber.Text = Guest.PassportNumber;
                ChkbAddPassportDetails.Checked = true;
            }

            if (Guest.PassportExpirationDate.HasValue)
                Calendar.Value = Guest.PassportExpirationDate.Value;

            if (Guest.CountryOfIssue.HasValue)
                cmbCountries2.SelectedValue = Guest.CountryOfIssue;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsValideInputs()
        {
            bool ValideInputs = true;

            if (string.IsNullOrEmpty(txtbFirstName.Text))
            {
                InputErrorProvider.SetError(txtbFirstName, "Enter a FirstName Here!");
                ValideInputs= false;
            }
            else InputErrorProvider.SetError(txtbFirstName, string.Empty);


            if (string.IsNullOrEmpty(txtbLastName.Text))
            {
                InputErrorProvider.SetError(txtbLastName, "Enter a LastName Here!");
                ValideInputs = false;
            }
            else InputErrorProvider.SetError(txtbLastName, string.Empty);


            if (string.IsNullOrEmpty(txtbNationalNumber.Text))
            {
                InputErrorProvider.SetError(txtbNationalNumber, "Enter a National Number Here!");
                ValideInputs = false;
            }
            else if (clsGuest.IsGuestExists(txtbNationalNumber.Text) && ((Guest.Mode == clsGuest.enModes.AddNew) || (Guest.Mode == clsGuest.enModes.Update && Guest.NationalNumber != txtbNationalNumber.Text)) )
            {
                InputErrorProvider.SetError(txtbNationalNumber, "This national number is already used by another guest!");
                ValideInputs = false;
                
            }
            else InputErrorProvider.SetError(txtbNationalNumber,string.Empty);


            if (string.IsNullOrEmpty(txtbPhone.Text))
            {
                InputErrorProvider.SetError(txtbPhone, "Enter a Phone Number Here!");
                ValideInputs = false;
            }
            else InputErrorProvider.SetError(txtbPhone, string.Empty);


            if (ChkbAddPassportDetails.Checked)
            {
              if (string.IsNullOrEmpty(txtbPassportNumber.Text))
              {
                  InputErrorProvider.SetError(txtbPassportNumber, "Enter a Passport Number Here!");
                  ValideInputs = false;
              }
              else if (clsGuest.PassportNumberAlreadyLinkedWithGuest(txtbPassportNumber.Text) && ((Guest.Mode == clsGuest.enModes.AddNew) || (Guest.Mode == clsGuest.enModes.Update && Guest.PassportNumber != txtbPassportNumber.Text)))
              {
                 InputErrorProvider.SetError(txtbPassportNumber, "This Passport number is already used by another guest!");
                 ValideInputs = false;

              }
              else InputErrorProvider.SetError(txtbPassportNumber, string.Empty);
            }
            return ValideInputs;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
          if (IsValideInputs())
          {
            Guest.FirstName = txtbFirstName.Text;
            Guest.LastName = txtbLastName.Text;
            Guest.NationalNumber = txtbNationalNumber.Text;
            Guest.Phone = txtbPhone.Text;
            Guest.Nationality = Convert.ToInt32(cmbCountries.SelectedValue);
            Guest.Gender = (rbMale.Checked) ? clsGuest.enGenders.Male : clsPerson.enGenders.Female;
            
            if (ChkbAddPassportDetails.Checked)
            {
              Guest.PassportNumber= txtbPassportNumber.Text;
              Guest.PassportExpirationDate = Calendar.Value;
              Guest.CountryOfIssue= Convert.ToInt32(cmbCountries2.SelectedValue);
            }
            else
            {
              if (!string.IsNullOrEmpty(Guest.PassportNumber))
              {
                CustomMessageBox.Text = "The Passport Details will be lost after saving\nAre you sure to continue?";
                CustomMessageBox.Caption = "Warning";
                CustomMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                CustomMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (CustomMessageBox.Show() == DialogResult.No) 
                    return;
              }
              Guest.PassportNumber = null;
              Guest.PassportExpirationDate = null;
              Guest.CountryOfIssue = null;
             }


            if (Guest.Save())
            {
              
              GuestDataChanged(Guest.NationalNumber);
              
              lbGuestID.Text = Guest.GuestID.ToString();
              pbAddOrUpdateGuest.Image = Resources.updatePerson;

              CustomMessageBox.Text = "Data Saved Successfully.";
              CustomMessageBox.Caption = "Result";
              CustomMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
              CustomMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
              CustomMessageBox.Show();

              return;
            }
           
            CustomMessageBox.Text = "Operation Failed.";
            CustomMessageBox.Caption = "Error";
            CustomMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            CustomMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            CustomMessageBox.Show();
            
          }
        }

        private void ChkbAddPassportDetails_CheckedChanged(object sender, EventArgs e)
        {
            gbPassportInfo.Enabled = ChkbAddPassportDetails.Checked;
            if (!ChkbAddPassportDetails.Checked)
            {
                CustomMessageBox.Text = "Please be aware : If you don't select this option, the passport informations will not be included with the guest profile!";
                CustomMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                CustomMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                CustomMessageBox.Caption = "warning";
                CustomMessageBox.Show();
            }
        }
    }
}
