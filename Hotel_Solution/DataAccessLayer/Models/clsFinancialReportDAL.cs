using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer
{
    public static class clsFinancialReportDAL
    {

        private static FinancialReportDTO ExecuteFinancialReportSP(string storedProcedureName)
        {
            FinancialReportDTO report = new FinancialReportDTO();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.HotelDBConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                report.TotalBookings = reader.GetInt32(reader.GetOrdinal("TotalBookings"));
                                report.Revenue = (reader["Revenue"] == null) ? 0 :Convert.ToSingle(reader["Revenue"]);
                            }
                        }
                    }
                }
            }
            catch (Exception) { }
            
            return report;
        }

        public static FinancialReportDTO GetFinancialReportToday()
        {
            return ExecuteFinancialReportSP("SP_GetFinancialReportToday");
        }
       
        public static FinancialReportDTO GetFinancialReportLast7Days()
        {
            return ExecuteFinancialReportSP("SP_GetFinancialReportLast7Days");
        }

        public static FinancialReportDTO GetFinancialReportLast30Days()
        {
            return ExecuteFinancialReportSP("SP_GetFinancialReportLast30Days");
        }

        public static FinancialReportDTO GetFinancialReportLast3Months()
        {
            return ExecuteFinancialReportSP("SP_GetFinancialReportLast3Months");
        }

        public static FinancialReportDTO GetFinancialReportLast365Days()
        {
            return ExecuteFinancialReportSP("SP_GetFinancialReportLastYear");
        }
    }
}
