using System;
using System.Windows.Forms;

namespace hotel
{
    public partial class Form_CompleteBookingMessage : Form
    {
        public Form_CompleteBookingMessage(DateTime checkinDate,DateTime initialCheckOutDate,DateTime actualCheckOutDate,decimal initialAmount,decimal additionalAmount,decimal refundAmount,decimal totalAmount)
        {
            InitializeComponent();
            ShowInfo(checkinDate, initialCheckOutDate, actualCheckOutDate, initialAmount, additionalAmount,refundAmount,totalAmount);
        }

        private void ShowInfo(DateTime checkinDate, DateTime initialCheckOutDate, DateTime actualCheckOutDate, decimal initialAmount, decimal additionalAmount, decimal refundAmount, decimal totalAmount)
        {
            lbCheckIn.Text = checkinDate.ToShortDateString();
            lbInitialCheckOut.Text = initialCheckOutDate.ToShortDateString();
            lbActualCheckOut.Text = actualCheckOutDate.ToShortDateString();
            lbTotalDays.Text = $"{(actualCheckOutDate - checkinDate).Days} Day(s)";

            lbInitialPaidAmount.Text = $"{initialAmount} $";
            lbAdditionalAmount.Text = $"{additionalAmount} $"; 
            lbRefundAmount.Text =  $"{refundAmount} $";
            lbTotalAmount.Text = $"{totalAmount} $";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
