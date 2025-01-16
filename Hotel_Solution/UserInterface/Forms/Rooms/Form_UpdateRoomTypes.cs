using HotelProjectBusinessLayer;
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
    public partial class Form_UpdateRoomTypes : Form
    {
        public Action ExecuteAction;

        clsRoomType RoomType;

        public Form_UpdateRoomTypes(int roomTypeID)
        {
            InitializeComponent();
            FillTheFormWithRoomTypeInfo(roomTypeID);
        }
        private void FillTheFormWithRoomTypeInfo(int roomtypeid)
        {
            RoomType = clsRoomType.Find(roomtypeid);
            if (RoomType == null) 
            {
                CustomMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                CustomMessageDialog.Text = "Room Type Not Found !";
                CustomMessageDialog.Caption = "Result";
                CustomMessageDialog.Show();
                Close();

            }
            else
            {
                lbRoomID.Text = RoomType.RoomTypeID.ToString();
                txtbTitle.Text = RoomType.RoomTypeName;
                txtbDescription.Text = RoomType.Description;
                txtbPrice.Text = RoomType.PricePerNight.ToString();
                Capacity.Value = RoomType.Capacity;

            }

        }
        
        bool DataChanged()
        {
            return (RoomType.RoomTypeName != txtbTitle.Text) || (RoomType.Description != txtbDescription.Text)
                  || (RoomType.PricePerNight != Convert.ToSingle(txtbPrice.Text))
                  || Capacity.Value != Convert.ToDecimal(RoomType.Capacity);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!DataChanged()) return;

            RoomType.Capacity = Convert.ToByte(Capacity.Value);
            RoomType.Description = txtbDescription.Text;
            RoomType.RoomTypeName = txtbTitle.Text.Trim();
            RoomType.PricePerNight = Convert.ToSingle(txtbPrice.Text);

            if (RoomType.Update())
            {
                CustomMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                CustomMessageDialog.Text = "Data Updated Successfully.";
                CustomMessageDialog.Caption = "Result";
                CustomMessageDialog.Show();

                ExecuteAction.Invoke();
            }
            else
            {

                CustomMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                CustomMessageDialog.Text = "Operation Failed";
                CustomMessageDialog.Caption = "Result";
                CustomMessageDialog.Show();
            }
        }

    }
}
