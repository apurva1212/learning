using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
   public interface IPlayerEngine
    {
       (Player, Player, Player) CreatePlayers(string output);
    }
}
