using System;
using System.Data;
using System.Data.SqlClient;
using RoomDataAccessLayer.DTOs;


namespace HotelProjectDataAccessLayer
{
    public static class clsRoomDataAccessLayer
    {
        public static DataTable GetAllRooms()
        {
            DataTable RoomsDetails = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetRoomsDetails", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                RoomsDetails.Load(reader);
                            }
                            reader.Close();
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception) { }
            return RoomsDetails;

        }

        public static bool FindRoom(int roomId,ref int roomTypeId,ref short roomNumber,ref short floorNumber,ref bool isBooked)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_FindRoom", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@RoomID", SqlDbType.Int) { Value = roomId });

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                roomTypeId = Convert.ToInt32(reader["RoomTypeID"]);
                                roomNumber = Convert.ToInt16(reader["RoomNumber"]);
                                floorNumber = Convert.ToInt16(reader["FloorNumber"]);
                                isBooked = Convert.ToBoolean(reader["IsBooked"]);

                                IsFound = true;
                            }
                            reader.Close();
                        }
                    }
                    catch (Exception) { }
                    finally { connection.Close(); }
                   
                }
            }

            return IsFound;
        }

        public static RoomDTO GetRoomDetails(int RoomId)
        {
          
          RoomDTO room = null;

          using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
          {
              using (SqlCommand command = new SqlCommand("SP_GetRoomDetailsByRoomID", connection))
              {
                  command.CommandType = CommandType.StoredProcedure;
                  command.Parameters.Add(new SqlParameter("@RoomID", SqlDbType.Int) { Value = RoomId });

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                room = new RoomDTO
                                (
                                  RoomId,
                                  reader[1].ToString(),
                                  reader[2].ToString(),
                                  Convert.ToInt16(reader[3]),
                                  Convert.ToInt16(reader[4]),
                                  Convert.ToDecimal(reader[5]),
                                  reader[6].ToString()
                                );
                            }
                            reader.Close();
                            
                        }
                    }
                    catch (Exception) { }
                    finally { connection.Close(); }
                  
              }
          }
          return room;
        }
    

    }
}
