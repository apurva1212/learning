using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
   public interface IHotelService
    {
        // player name required as player can own a hotel
       void ProcessGame(Board gBoard, Player player, string playerName);
    }
}
