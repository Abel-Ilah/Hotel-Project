using System;
using System.Data.SqlClient;
using System.Data;
using System.Security;

namespace HotelProjectDataAccessLayer
{
    public static class clsRoomTypeDataAccessLayer
    {
        public static bool UpdateRoomType(int roomTypeID, string name, string description, byte capacity, float price)
        {
            bool IsUpdated = false;

            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                try
                {
                   
                    using (SqlCommand command = new SqlCommand("SP_UpdateRoomType", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@RoomTypeID", roomTypeID);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@Capacity", capacity);
                        command.Parameters.AddWithValue("@Price", price);

                        connection.Open();

                        if (command.ExecuteNonQuery()>0)
                            IsUpdated = true;

                        connection.Close();
                    }
                }
                catch (Exception) { }
        
            }
            return IsUpdated;
        }

        public static bool GetRoomTypeInfo(int RoomTypeID,ref string roomTypeName,ref string Description,ref byte capacity,ref float price )
        {
            bool IsFound=false;
          
           using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
           {
               using (SqlCommand command = new SqlCommand("SP_GetRoomTypeInfo", connection))
               {
                   command.CommandType = CommandType.StoredProcedure;
                   command.Parameters.Add(new SqlParameter("@RoomTypeID", RoomTypeID));

                   try
                   {
                     connection.Open();
                      using (SqlDataReader reader =command.ExecuteReader())
                      {
                        if (reader.Read())
                        {
                          roomTypeName = reader["RoomTypeName"].ToString();
                          Description = reader["Description"].ToString();
                          capacity =Convert.ToByte( reader["Capacity"]);
                          price = Convert.ToSingle( reader["PricePerNight"]);
                          IsFound = true; 
                        }
                      }
                   }
                  
                   catch (Exception) { }
                   finally { connection.Close(); }
               }
           }

           return IsFound;
            
        }

        public static DataTable GetAllRoomTypes()
        {
            DataTable RoomTypesTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetAllRoomTypes", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                RoomTypesTable.Load(reader);
                            }
                            reader.Close();
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception) { }
            return RoomTypesTable;


        }



    }
}
