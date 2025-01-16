using HotelProjectDataAccessLayer;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelProjectDataAccessLayer
{
    public static class clsBookingDataAccessLayer
    {
        public static int AddNewBooking(int roomID, int guestID, byte numberOfPeople, DateTime checkIn, DateTime checkOut, float paidAmount, byte bookingStatus)
        {
            int NewBookingID = -1;

            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewBooking", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.AddWithValue("@GuestID", guestID);
                    command.Parameters.AddWithValue("@BookingRoomID", roomID);
                    command.Parameters.AddWithValue("@NumberOFGuests", numberOfPeople);
                    command.Parameters.AddWithValue("@CheckIn", checkIn);
                    command.Parameters.AddWithValue("@CheckOut", checkOut);
                    command.Parameters.AddWithValue("@PaidAmount", paidAmount);
                    command.Parameters.AddWithValue("@BookingStatus", bookingStatus);

                    // Output parameter for BookingID
                    SqlParameter bookingIdParam = new SqlParameter("@BookingID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(bookingIdParam);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the command
                        command.ExecuteNonQuery();

                        // Retrieve the BookingID from the output parameter
                        if (bookingIdParam.Value != null && int.TryParse(bookingIdParam.Value.ToString(), out int ID))
                        {
                            NewBookingID = ID;
                        }
                    }
                    catch (SqlException) { }
                    finally { connection.Close(); }
                }
            }
            return NewBookingID;

        }
        
        public static DataTable GetBookingsInfoBasedOnCheckInDate(DateTime CheckInDate,int PageNumber,int RowsPerPage, ref int TotalRows)
        {
            DataTable bookingsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetBookingsDetailsBasedOnCheckInDate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@Date", CheckInDate));
                    command.Parameters.Add(new SqlParameter("@PageNumber", PageNumber));
                    command.Parameters.Add(new SqlParameter("@RowsPerPage", RowsPerPage));
                    SqlParameter totalRowsParam = new SqlParameter("@TotalRows", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(totalRowsParam);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                bookingsTable.Load(reader);
                                if (totalRowsParam.Value != DBNull.Value)
                                    TotalRows = (int)totalRowsParam.Value;
                            }
                            else TotalRows = 0;
                            reader.Close();
                        }
                    }
                    catch (Exception) { }
                    finally { connection.Close(); }
                    
                }
            }

            return bookingsTable;
        }
        public static DataTable GetBookingsInfoThatWereActiveInASpecificDae(DateTime Date, int PageNumber, int RowsPerPage,ref int TotalRows)
        {
            DataTable bookingsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetBookingsDetailsThatWereActiveInASpecificDate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@Date", Date));
                    command.Parameters.Add(new SqlParameter("@PageNumber", PageNumber));
                    command.Parameters.Add(new SqlParameter("@RowsPerPage", RowsPerPage));

                    SqlParameter totalRowsParam = new SqlParameter("@TotalRows", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(totalRowsParam);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                bookingsTable.Load(reader);
                                if (totalRowsParam.Value != DBNull.Value)
                                TotalRows = (int)totalRowsParam.Value;
                            }
                            else TotalRows = 0;
                            reader.Close();
                        }
                    }
                    catch (Exception) { }
                    finally { connection.Close(); }

                }
            }

            return bookingsTable;
        }
        public static DataTable GetBookingsInfoBasedOnNationalNumber(string NationalNumber, int PageNumber, int RowsPerPage, ref int TotalRows)
        {
            DataTable bookingsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetBookingsDetailsBasedOnNationalNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@NationalNumber", NationalNumber));
                    command.Parameters.Add(new SqlParameter("@PageNumber", PageNumber));
                    command.Parameters.Add(new SqlParameter("@RowsPerPage", RowsPerPage));
                    SqlParameter totalRowsParam = new SqlParameter("@TotalRows", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(totalRowsParam);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                bookingsTable.Load(reader);
                                if (totalRowsParam.Value != DBNull.Value)
                                TotalRows = (int)totalRowsParam.Value;
                            }
                            else TotalRows = 0;
                            reader.Close();
                        }
                    }
                    catch (Exception) { }
                    finally { connection.Close(); }

                }
            }

            return bookingsTable;
        }
        public static DataTable GetShortBookingsInfoBasedOnNationalNumber(string NationalNumber)
        {
            DataTable bookingsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetShortBookingsDetailsBasedOnNationalNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@NationalNumber", NationalNumber));
                 
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                bookingsTable.Load(reader);

                            reader.Close();
                        }
                    }
                    catch (Exception) { }
                    finally { connection.Close(); }

                }
            }

            return bookingsTable;
        }
        public static DataTable GetActiveBookingsInfo(int PageNumber, int RowsPerPage, ref int TotalRows)
        {
            DataTable bookingsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetActiveBookingsDetails", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@PageNumber", PageNumber));
                    command.Parameters.Add(new SqlParameter("@RowsPerPage", RowsPerPage));
                    SqlParameter totalRowsParam = new SqlParameter("@TotalRows", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(totalRowsParam);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                bookingsTable.Load(reader);
                                if (totalRowsParam.Value!=DBNull.Value)
                                 TotalRows = (int)totalRowsParam.Value;
                            }
                            else TotalRows = 0;
                            reader.Close();
                        }
                    }
                    catch (Exception) { }
                    finally { connection.Close(); }

                }
            }

            return bookingsTable;
        }
        public static DataTable GetAllBookings(int PageNumber, int RowsPerPage, ref int TotalRows)
        {
            DataTable bookingsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllBookings", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@PageNumber", PageNumber));
                    command.Parameters.Add(new SqlParameter("@RowsPerPage", RowsPerPage));
                    SqlParameter totalRowsParam = new SqlParameter("@TotalRows", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(totalRowsParam);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                bookingsTable.Load(reader);
                                if (totalRowsParam.Value != DBNull.Value)
                                    TotalRows = (int)totalRowsParam.Value;
                            }
                            else TotalRows = 0;
                            reader.Close();
                        }
                    }
                    catch (Exception) { }
                    finally { connection.Close(); }

                }
            }

            return bookingsTable;
        }
        public static bool UpdateBookingStatus(int bookingId,DateTime ActualCheckOut, decimal ActualPaidAmount, byte bookingStatus, int roomId)
        {
            bool IsUpdated = false;
            using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateBookingStatus", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@BookingID", bookingId));
                    command.Parameters.Add(new SqlParameter("@ActualCheckOut", ActualCheckOut));
                    command.Parameters.Add(new SqlParameter("@ActualPaidAmount", ActualPaidAmount));
                    command.Parameters.Add(new SqlParameter("@BookingStatus", bookingStatus)); // bool parameter
                    command.Parameters.Add(new SqlParameter("@RoomId", roomId));

                    try
                    {
                        connection.Open();
                        IsUpdated = command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception) { }
                    finally { connection.Close(); }
                   
                }
            }
            return IsUpdated;
        }




    }   
}
