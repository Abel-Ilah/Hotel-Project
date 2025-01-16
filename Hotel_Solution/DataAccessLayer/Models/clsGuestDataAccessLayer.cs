using System;
using System.Data.SqlClient;
using System.Data;
using HotelProjectDataAccessLayer;
using System.Net.Http.Headers;

namespace HotelProjectDataAccessLayer
{
    public static class clsGuestDataAccessLayer
    {
      public static bool AddNewGuest(ref int GuestID, ref int personId, string firstName, string lastName, string phone,
                                    bool gender, int nationality, string nationalNumber, string passportNumber,
                                    DateTime? passportExpirationDate, int? countryOfIssue)
      {
          
            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewGuest", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Nationality", nationality);
                    command.Parameters.AddWithValue("@NationalNumber", nationalNumber);
                    command.Parameters.AddWithValue("@PassportNumber", passportNumber ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@PassportExpirationDate", passportExpirationDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CountryOfIssue", countryOfIssue ?? (object)DBNull.Value);

                    // Output parameters
                    SqlParameter guestIDParam = new SqlParameter("@GuestID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(guestIDParam);

                    SqlParameter personIDParam = new SqlParameter("@PersonID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(personIDParam);

                    try
                    {
                      connection.Open();
                      command.ExecuteNonQuery();
                      
                      if (guestIDParam.Value != null && int.TryParse(guestIDParam.Value.ToString(), out int result1))
                      {
                          GuestID = result1;
                      }
                      
                      if (personIDParam.Value != null && int.TryParse(personIDParam.Value.ToString(), out int result2))
                      {
                          personId = result2;
                      }
                      
                      // Retrieve the output parameter values
                    }
                    catch (SqlException) { }
                    finally { connection.Close(); }
                    
                }
            }
            return GuestID > -1;
        }

        public static bool UpdateGuest(int guestID,int personID, string firstName, string lastName, string phone, bool gender,
                          int nationality, string nationalNumber, string passportNumber,
                          DateTime? passportExpirationDate, int? countryOfIssue)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateGuest", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Nationality", nationality);
                        command.Parameters.AddWithValue("@NationalNumber", nationalNumber);
                        command.Parameters.AddWithValue("@PassportNumber", (object)passportNumber ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PassportExpirationDate", (object)passportExpirationDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CountryOfIssue", (object)countryOfIssue ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GuestID", guestID);

                        connection.Open();
                        rowsAffected = (int)command.ExecuteScalar();
                      connection.Close();
                       
                    }
                }
            }
            catch (Exception) { }
            return rowsAffected > 0;
        }



        public static bool FindGuestByGuestID(int GuestID,ref int personId, ref string firstName, ref string lastName,
                                            ref string phone, ref bool gender, ref int nationality,
                                            ref string nationalNumber, ref string passportNumber,
                                            ref DateTime? passportExpirationDate, ref int? countryOfIssue)
      {
         bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_FindGuestByGuestID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add input parameter
                    command.Parameters.AddWithValue("@GuestID", GuestID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                              personId = Convert.ToInt32(reader["PersonID"]);
                              firstName = reader["FirstName"].ToString();
                              lastName = reader["LastName"].ToString();
                              phone = reader["Phone"].ToString();
                              gender = Convert.ToBoolean(reader["Gender"]);

                              nationality = Convert.ToInt32(reader["Nationality"]);
                              nationalNumber = reader["NationalNumber"].ToString();
                              
                              if (reader["PassportNumber"] != DBNull.Value)
                                  passportNumber = reader["PassportNumber"].ToString();
                              else passportNumber = null;

                              if (reader["PassportExpirationDate"] != DBNull.Value)
                                  passportExpirationDate = Convert.ToDateTime(reader["PassportExpirationDate"]);
                              else passportExpirationDate = null;

                              if (reader["CountryOfIssue"] != DBNull.Value)
                                  countryOfIssue = Convert.ToInt32(reader["CountryOfIssue"]);
                              else countryOfIssue = null;

                                IsFound = true;
                            }
                        }
                    }
                    catch (SqlException) { }
                   finally { connection.Close(); }
                }
            }
            return IsFound;
        }

      public static bool FindGuestByNationalNumber(ref int GuestID, ref int personId, ref string firstName, ref string lastName,
                                              ref string phone, ref bool gender, ref int nationality,
                                              string nationalNumber, ref string passportNumber,
                                              ref DateTime? passportExpirationDate, ref int? countryOfIssue)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_FindGuestByNationalNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add input parameter
                    command.Parameters.AddWithValue("@NationalNumber", nationalNumber);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                personId = Convert.ToInt32(reader["PersonID"]);
                                firstName = reader["FirstName"].ToString();
                                lastName = reader["LastName"].ToString();
                                phone = reader["Phone"].ToString();
                                gender = Convert.ToBoolean(reader["Gender"]);

                                GuestID = Convert.ToInt32(reader["GuestID"]);
                                nationality = Convert.ToInt32(reader["Nationality"]);
                                
                                if (reader["PassportNumber"] != DBNull.Value)
                                    passportNumber = reader["PassportNumber"].ToString();
                                else passportNumber = null;

                                if (reader["PassportExpirationDate"] != DBNull.Value)
                                    passportExpirationDate = Convert.ToDateTime(reader["PassportExpirationDate"]);
                                else passportExpirationDate = null;

                                if (reader["CountryOfIssue"] != DBNull.Value)
                                    countryOfIssue = Convert.ToInt32(reader["CountryOfIssue"]);
                                else countryOfIssue = null;

                                IsFound = true;
                            }
                        }
                    }
                    catch (SqlException) { }
                    finally { connection.Close(); }
                }
            }
            return IsFound;
        }

        public static bool FindGuestByPassportNumber(ref int GuestID, ref int personId, ref string firstName, ref string lastName,
                                            ref string phone, ref bool gender, ref int nationality,
                                           ref string nationalNumber, string passportNumber,
                                            ref DateTime? passportExpirationDate, ref int? countryOfIssue)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_FindGuestByPassportNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add input parameter
                    command.Parameters.AddWithValue("@PassportNumber", passportNumber);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                personId = Convert.ToInt32(reader["PersonID"]);
                                firstName = reader["FirstName"].ToString();
                                lastName = reader["LastName"].ToString();
                                phone = reader["Phone"].ToString();
                                gender = Convert.ToBoolean(reader["Gender"]);

                                GuestID = Convert.ToInt32(reader["GuestID"]);
                                nationalNumber = reader["NationalNumber"].ToString();
                                nationality = Convert.ToInt32(reader["Nationality"]);

                                if (reader["PassportExpirationDate"] != DBNull.Value)
                                    passportExpirationDate = Convert.ToDateTime(reader["PassportExpirationDate"]);
                                else passportExpirationDate = null;

                                if (reader["CountryOfIssue"] != DBNull.Value)
                                    countryOfIssue = Convert.ToInt32(reader["CountryOfIssue"]);
                                else countryOfIssue = null;

                                IsFound = true;
                            }
                        }
                    }
                    catch (SqlException) { }
                    finally { connection.Close(); }
                }
            }
            return IsFound;
        }





        
      public static bool IsGuestExistsByNationalNumber(string NationalNumber)
        {
            bool IsExists=false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_IsGuestExistsByNationalNumber", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@NationalNumber", NationalNumber));

                        object result = command.ExecuteScalar();
                        IsExists = result != null && (int)result == 1;
                    }
                    connection.Close();
                }
            }
            catch (Exception) {}
            return IsExists;
        }

      public static bool IsGuestExistsByPassportNumber(string PassportNumber)
        {
            if (string.IsNullOrEmpty(PassportNumber)) return false;

            bool IsExists = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_IsGuestExistsByPassportNumber", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@PassportNumber", PassportNumber));

                        object result = command.ExecuteScalar();
                        IsExists = result != null && (int)result == 1;
                    }
                    connection.Close();
                }
            }
            catch (Exception) { }
            return IsExists;
        }

    }
}
