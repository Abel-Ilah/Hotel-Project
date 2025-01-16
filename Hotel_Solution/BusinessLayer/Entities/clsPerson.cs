using System;


namespace HotelProjectBusinessLayer
{
    public abstract class clsPerson
    {
        public int PersonID { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Phone { get; set; } 

        public string FullName { get { return FirstName + " " + LastName;  } }

        public enum enGenders
        {
            Male = 0,
            Female = 1
        }

        public enGenders Gender { get; set; }

    }
}
