using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomDataAccessLayer.DTOs
{
    public class RoomDTO
    {
        public int RoomID { get; set; }
        public string RoomType { get; set; }
        public string Description { get; set; }
        public short RoomNumber { get; set; }
        public short Floor { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }

        // Constructor to initialize the properties
        public RoomDTO(int roomID, string roomType, string description, short roomNumber, short floor, decimal price, string status)
        {
            RoomID = roomID;
            RoomType = roomType;
            Description = description;
            RoomNumber = roomNumber;
            Floor = floor;
            Price = price;
            Status = status;
        }
   
    }

}
