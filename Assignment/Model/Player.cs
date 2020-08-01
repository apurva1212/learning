using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Model
{
   public class Player
    {
        public Player()
        {
            Moves = new List<int>();
            HotelOwned = new List<Hotel>(); ;
        }

        public int Money { get; set; } = 1000;

         public List<int> Moves { get; set; }

        public int MovedPlayed { get; set; }

        public List<Hotel> HotelOwned { get; set; }
    }
}
