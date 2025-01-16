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
    public partial class Form_ShowRoomDetails : Form
    {
        int RoomID;
        public Form_ShowRoomDetails(int roomID)
        {
            InitializeComponent();
            RoomID = roomID;
        }

        private void Form_ShowRoomDetails_Load(object sender, EventArgs e)
        {
            uC_RoomDetails1.LoadRoomDetails(RoomID);
        }
    }
}
