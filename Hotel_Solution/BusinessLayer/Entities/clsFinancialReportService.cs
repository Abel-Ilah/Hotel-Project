using HotelProjectDataAccessLayer;
using System;


namespace HotelProjectBusinessLayer
{
    public static class clsFinancialReportService
    {
        public static FinancialReportDTO GetFinancialReportToday()
        {
            return  clsFinancialReportDAL.GetFinancialReportToday();
        }
        public static FinancialReportDTO GetFinancialReportLast7Days()
        {
            return clsFinancialReportDAL.GetFinancialReportLast7Days();
        }
        public static FinancialReportDTO GetFinancialReportLast30Days()
        {
            return clsFinancialReportDAL.GetFinancialReportLast30Days();
        }
        public static FinancialReportDTO GetFinancialReportLast3Months()
        {
            return clsFinancialReportDAL.GetFinancialReportLast3Months();
        }
        public static FinancialReportDTO GetFinancialReportLast365Days()
        {
            return clsFinancialReportDAL.GetFinancialReportLast365Days();
        }

    }
}
