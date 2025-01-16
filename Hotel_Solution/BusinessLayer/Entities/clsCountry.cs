 
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProjectDataAccessLayer;

namespace HotelProjectBusinessLayer
{
    public static class clsCountry
    {

        public static DataTable GetAllCountries()
        {
            return clsCountryDataAccessLayer.GetAllCountries();
        }

        public static string GetCountryName(int CountryID)
        {
            return clsCountryDataAccessLayer.GetCountryNameByCountryID(CountryID);
        }
    }
}
