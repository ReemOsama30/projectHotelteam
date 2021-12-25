using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject
{
    public class RoomType
    {
        public int ID
        {
            set; get;
        }
        public string Type
        {
            set; get;
        }
        public double price_Per_Night
        {
            set; get;
        }
        public int Number_Of_Beds
        {
            set; get;
        }
        public int Number_Of_Chairs
        {
            set; get;
        }

        public virtual IEnumerable<Room> Rooms { get; set; }

    }
}
