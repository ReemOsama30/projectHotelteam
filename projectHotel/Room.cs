using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject
{
   public class Room
    {
        public int ID
        {
            set; get;
        }
  
        public int RoomTypeID
        {
            set; get;
        }
        public bool isReserved { get; set; } = false;
        public virtual RoomType RoomType { get; set; }
        public virtual IEnumerable<Booking> books { get; set; }
    }
}
