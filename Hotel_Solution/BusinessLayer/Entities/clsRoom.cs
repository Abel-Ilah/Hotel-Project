using System;
using System.Data;
using System.Security.Policy;
using HotelProjectDataAccessLayer;
using RoomDataAccessLayer.DTOs;


namespace HotelProjectBusinessLayer
{
    public class clsRoom
    {
        public int RoomID { get; set; }

        public int RoomTypeID { get; set; }

        public short RoomNumber { get; set; }

        public short FloorNumber { get; set; }

        public bool IsBooked { get; set; }

        private clsRoom(int roomID, int roomTypeID, short roomNumber, short floorNumber, bool isBooked)
        {
           
            RoomID = roomID;
            RoomTypeID = roomTypeID;
            RoomNumber = roomNumber;
            FloorNumber = floorNumber;
            IsBooked = isBooked;
        }

        public static DataTable GetAllRooms()
        {
            return clsRoomDataAccessLayer.GetAllRooms();

        }

        public static clsRoom Find(int roomID)
        {
            int roomTypeID=-1;
            short roomNumber=-1, floorNumber=-1;
            bool isBooked=false;
            
            if (clsRoomDataAccessLayer.FindRoom(roomID,ref roomTypeID,ref roomNumber,ref floorNumber,ref isBooked))
            {
                return new clsRoom(roomID, roomTypeID, roomNumber, floorNumber, isBooked);
            }
            return null;
        }

        // this function return the full room details using joins between tables in database 
        public static RoomDTO GetRoomDetails(int RoomID) 
        {
         return clsRoomDataAccessLayer.GetRoomDetails(RoomID);
        }

       
    }

}
