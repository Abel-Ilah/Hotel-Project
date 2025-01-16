using HotelProjectBusinessLayer;
using HotelProjectDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class UC_Revenue : UserControl
    {
        public UC_Revenue()
        {
            InitializeComponent();
            cmbPeriodFilter.SelectedIndex= 0;
        }

        public void ShowRevenue()
        {
            FinancialReportDTO report = null;

            string selectedPeriod = cmbPeriodFilter.Text;

            switch (selectedPeriod)
            {
                case "Today":
                    report = clsFinancialReportService.GetFinancialReportToday();
                    break;

                case "Last 7 Days":
                    report = clsFinancialReportService.GetFinancialReportLast7Days();
                    break;

                case "Last 30 Days":
                    report = clsFinancialReportService.GetFinancialReportLast30Days();
                    break;

                case "Last 90 Days":
                    report = clsFinancialReportService.GetFinancialReportLast3Months();
                    break;

                case "Last 365 Days":
                    report = clsFinancialReportService.GetFinancialReportLast365Days();
                    break;

                default:
                    report = clsFinancialReportService.GetFinancialReportToday();
                    break;
            }

            if (report == null)
            {
                lbRevenue.Text = "0 $";
                lbTotalBookings.Text = "0";
                return;
            }
            lbRevenue.Text = $"{report.Revenue.ToString() } $";
            lbTotalBookings.Text = report.TotalBookings.ToString();
        }

        private void cmbPeriodFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRevenue();
        }

    }    
}
