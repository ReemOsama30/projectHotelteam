using System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject
{
    public class client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone_Number { get; set; }
       // public int Room_ID { get; set; }


        public virtual IEnumerable<Booking> books { get; set; }
    }
}
