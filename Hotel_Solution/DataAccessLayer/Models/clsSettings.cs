using System;
using System.Configuration;

namespace HotelProjectDataAccessLayer
{
    public  class clsSettings
    {
      public static string HotelDBConnectionString = ConfigurationManager.ConnectionStrings["HotelDBConnectionString"].ConnectionString;

    }
}
