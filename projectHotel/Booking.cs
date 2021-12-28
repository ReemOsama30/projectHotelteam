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
        public int Number_Of_Days 
        {
            set; get;
        }
        public bool isFinish { get; set; } = false;
        public virtual client clients { get; set; }
        public virtual Room room { get; set; }
        public double TotalPrice { get; set; }
    }
}
