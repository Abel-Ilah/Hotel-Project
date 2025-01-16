using HotelProjectDataAccessLayer;
using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;


namespace HotelProjectBusinessLayer
{
    public class clsRoomType
    {
       
        public int RoomTypeID { get;}

        public string RoomTypeName { get; set; }

        public string Description { get; set; }

        public byte Capacity { get; set; }

        public float PricePerNight { get; set; }

        private clsRoomType(int roomTypeID, string roomTypeName, string description, byte capacity, float pricePerNight)
        {
           
            RoomTypeID = roomTypeID;
            RoomTypeName = roomTypeName;
            Description = description;
            Capacity = capacity;
            PricePerNight = pricePerNight;
          
        }
        public bool Update()
        {
            return clsRoomTypeDataAccessLayer.UpdateRoomType(RoomTypeID, RoomTypeName, Description, Capacity,PricePerNight);
        }
        public static clsRoomType Find(int RoomTypeID)
        {
            string roomTypeName = null, description = null;
            byte capacity = 0;
            float pricePerNight = 0;

            if (clsRoomTypeDataAccessLayer.GetRoomTypeInfo(RoomTypeID,ref roomTypeName,ref description,ref capacity,ref pricePerNight))
            {
                return new clsRoomType(RoomTypeID,roomTypeName,description,capacity,pricePerNight);
            }
            return null;
        }
        public static DataTable GetAllRoomTypes()
        {
            return clsRoomTypeDataAccessLayer.GetAllRoomTypes();
        }


    }
}
