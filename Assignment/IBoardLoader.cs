using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
     public interface IBoardLoader
    {
      public  Board LoadBoard(string cells);
     public  (Player, Player, Player) LoadPlayers(string diceOutput);

    }
}
