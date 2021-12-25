using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject
{
    public class Booking
    {
        public int ID
        {
            set;get;
        }
        public int client_ID
        {
            set;get;
        }
        public int Room_ID
        {
            set; get;
        }
        public int reciptionist_ID
        {
            set; get;
        }
        public string Booking_Date
        {
            set; get;
        }
        public int Number_Of_Days
        {
            set; get;
        }
    }
}
