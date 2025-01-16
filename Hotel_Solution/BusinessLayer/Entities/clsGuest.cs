using HotelProjectDataAccessLayer;
using System;


namespace HotelProjectBusinessLayer
{
    public class clsGuest:clsPerson
    {
      public int GuestID { get; set; } // Identity column, primary key
      public int Nationality { get; set; } // Foreign key to Countries
      public string NationalNumber { get; set; } // Unique national number
      public string PassportNumber { get; set; } // Unique passport number, nullable
      public DateTime? PassportExpirationDate { get; set; } // Nullable date
      public int? CountryOfIssue { get; set; } // Country of passport issue

      public enum enModes { AddNew = 1, Update = 2 }
      public enModes Mode;
      public clsGuest() 
      { 
        GuestID = -1;
        PersonID = -1;
        Gender = enGenders.Male;
        PassportNumber = null;
        PassportExpirationDate = null;
        CountryOfIssue = null;

        Mode = enModes.AddNew;
      }

      private clsGuest(int guestID,int personId,string firstName,string lastName,string phone,enGenders gender, int nationality, string nationalNumber, string passportNumber, DateTime? passportExpirationDate, int? countryOfIssue)
      {
          //person info : 
          PersonID = personId;
          FirstName= firstName;
          LastName= lastName;
          Phone = phone;
         
          Gender = gender;

          //guest info:
          GuestID = guestID;
          Nationality = nationality;
          NationalNumber = nationalNumber;
          PassportNumber = passportNumber;
          PassportExpirationDate = passportExpirationDate;
          CountryOfIssue = countryOfIssue;

          Mode = enModes.Update;
      }

      private bool _AddNewGuest()
        {
            
            int guestid = -1, personid = -1;

            if (clsGuestDataAccessLayer.AddNewGuest(ref guestid, ref personid, FirstName, LastName, Phone, Convert.ToBoolean(Gender), Nationality, NationalNumber, PassportNumber, PassportExpirationDate, CountryOfIssue))
            {
                GuestID = guestid;
                PersonID= personid;
                return true;
            }
            return false;
        }
      private bool _UpdateGuest()
       {
         return clsGuestDataAccessLayer.UpdateGuest(GuestID,PersonID,FirstName,LastName,Phone, Convert.ToBoolean(Gender), Nationality, NationalNumber, PassportNumber, PassportExpirationDate,CountryOfIssue);
       }
      public bool Save()
        {
            switch (Mode)
            {
                case enModes.AddNew:
                    if (_AddNewGuest())
                    {
                        Mode = enModes.Update;
                        return true;
                    }
                    break;
                case enModes.Update:
                    return _UpdateGuest();

            }
            return false;
        }
      public static bool IsGuestExists(string NationalNumber)
      {
          return clsGuestDataAccessLayer.IsGuestExistsByNationalNumber(NationalNumber);
      }
      public static bool PassportNumberAlreadyLinkedWithGuest(string PassportNumber)
      {
            return clsGuestDataAccessLayer.IsGuestExistsByPassportNumber(PassportNumber);
      }

      public static clsGuest FindByGuestID(int GuestID) 
      {
            int personId = -1, nationality=-1;
            string firstName=null, lastName=null, phone=null, nationalNumber=null, passportNumber=null;
            bool gender=false;
            DateTime? passportExpirationDate = null;
            int? CountryOfIssue=null;

            if (clsGuestDataAccessLayer.FindGuestByGuestID(GuestID,ref personId,ref firstName,ref lastName,ref phone,ref gender,ref nationality,ref nationalNumber,ref passportNumber,ref passportExpirationDate,ref CountryOfIssue))
            {
                return new clsGuest(GuestID, personId, firstName, lastName, phone, gender?enGenders.Female:enGenders.Male , nationality, nationalNumber, passportNumber, passportExpirationDate, CountryOfIssue);
            }
            return null;

      }
      public static  clsGuest FindByNationalNumber(string NationalNumber)
      {
          int personId = -1, nationality = -1, GuestId = -1;
          string firstName = null, lastName = null, phone = null, passportNumber = null;
          bool gender = false;
          DateTime? passportExpirationDate = null;
          int? CountryOfIssue = null;

          if (clsGuestDataAccessLayer.FindGuestByNationalNumber(ref GuestId, ref personId, ref firstName, ref lastName, ref phone, ref gender, ref nationality, NationalNumber, ref passportNumber, ref passportExpirationDate, ref CountryOfIssue))
          {
              return new clsGuest(GuestId, personId, firstName, lastName, phone, gender ? enGenders.Female : enGenders.Male, nationality, NationalNumber, passportNumber, passportExpirationDate, CountryOfIssue);
          }
          return null;

      }
      public static clsGuest FindByPassportNumber(string PassportNumber)
        {
            int personId = -1, nationality = -1, GuestId = -1;
            string firstName = null, lastName = null, phone = null, nationalNumber = null;
            bool gender = false;
            DateTime? passportExpirationDate = null;
            int? CountryOfIssue = null;

            if (clsGuestDataAccessLayer.FindGuestByPassportNumber(ref GuestId, ref personId, ref firstName, ref lastName, ref phone, ref gender, ref nationality,ref nationalNumber, PassportNumber, ref passportExpirationDate, ref CountryOfIssue))
            {
                return new clsGuest(GuestId, personId, firstName, lastName, phone, gender ? enGenders.Female : enGenders.Male, nationality,nationalNumber,PassportNumber, passportExpirationDate, CountryOfIssue);
            }
            return null;

        }


    }
}
