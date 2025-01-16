using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer
{
    public static class clsCountryDataAccessLayer
    {

        public static DataTable GetAllCountries()
        {
            DataTable countriesTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllCountries", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            
                            if (reader.HasRows)
                            {
                                countriesTable.Load(reader);
                            }
                            
                        }
                    }
                    catch (Exception) { }
                    finally { connection.Close(); }
                }
            }

            return countriesTable;
        }

        public static string GetCountryNameByCountryID(int countryId)
        {
            string countryName = null;

            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetCountryNameByCountryID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CountryID", countryId); // Assuming the parameter is named 'countryid'

                    connection.Open();
                    object result = command.ExecuteScalar(); // ExecuteScalar to get a single value

                    if (result != null)
                    {
                        countryName = result.ToString(); // Convert the result to string
                    }
                }
            }

            return countryName;
        }





    }
}
