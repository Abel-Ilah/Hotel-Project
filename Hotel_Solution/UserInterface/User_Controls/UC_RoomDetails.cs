using HotelProjectBusinessLayer;
using RoomDataAccessLayer.DTOs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace hotel
{
    public partial class UC_RoomDetails : UserControl
    {
        public UC_RoomDetails()
        {
            InitializeComponent();
        }

        RoomDTO RoomDetails = null;

        private void ResetDefaultInfo()
        {
            lbRoomID.Text = "[#####]";
            lbRoomType.Text = "[#####]";
            lbDescription.Text = "[#####]";
            lbRoomNumber.Text = "[#####]";
            lbFloor.Text = "[#####]";
            lbPrice.Text = "[#####]";
            lbStatus.Text = "[#####]";
            lbStatus.ForeColor = Color.Gray;
        }
        public void LoadRoomDetails(int RoomID)
        {
            RoomDetails = clsRoom.GetRoomDetails(RoomID);
            if (RoomDetails != null)
            {
                lbRoomID.Text = RoomDetails.RoomID.ToString();
                lbRoomType.Text = RoomDetails.RoomType;
                lbDescription.Text = RoomDetails.Description;
                lbRoomNumber.Text= RoomDetails.RoomNumber.ToString();
                lbFloor.Text= RoomDetails.Floor.ToString();
                lbPrice.Text= RoomDetails.Price.ToString();
                lbStatus.Text = RoomDetails.Status;
                if (RoomDetails.Status == "Available")
                     lbStatus.ForeColor = Color.Green;
                else lbStatus.ForeColor = Color.Red;
            }
            else
            {
                ResetDefaultInfo();
                CustomMessageBox.Parent = this.ParentForm;
                CustomMessageBox.Show();
            }

        }

    }
}
