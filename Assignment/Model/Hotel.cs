using Assignment.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Model
{
    public class Hotel
    {
        public HotelType Type  { get; set; }

        public int Value { get; set; }

        public int Rent { get; set; }

        public string Ownedby { get; set; }

        public string Rentedto { get; set; }
    }
}
