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
    public partial class Form_RoomTypes : Form
    {
        DataTable RoomTypesTable;
        public Form_RoomTypes()
        {
            InitializeComponent();
            RoomTypesTable = new DataTable();
        }

        private void GetAllRoomTypes()
        {
            RoomTypesTable = clsRoomType.GetAllRoomTypes();
            dgvRoomTypes.DataSource = RoomTypesTable.DefaultView;

            if (dgvRoomTypes.Columns.Count == 5)
            {
                dgvRoomTypes.Columns[0].Width = 100;
                dgvRoomTypes.Columns[1].Width = 180;
                dgvRoomTypes.Columns[2].Width = 450;
                dgvRoomTypes.Columns[3].Width = 100;
            }

        }

        private void Form_RoomTypes_Load(object sender, EventArgs e)
        {
            GetAllRoomTypes();
        }

        private void RoomTypesContexMenueStrip_Opening(object sender, CancelEventArgs e)
        {
            RoomTypesContexMenueStrip.Enabled =(dgvRoomTypes.Rows.Count > 0);
        }

        private void UpdateRoomInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UpdateRoomTypes frm = new Form_UpdateRoomTypes(Convert.ToInt32(dgvRoomTypes.CurrentRow.Cells["ID"].Value));
            frm.ExecuteAction += () =>
            {
                RoomTypesTable = clsRoomType.GetAllRoomTypes();
                dgvRoomTypes.DataSource = RoomTypesTable.DefaultView;
            };
            frm.ShowDialog();
        }

    }
}
