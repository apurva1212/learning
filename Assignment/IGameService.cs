using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
   public interface IGameService
    {
        //Check return type later
       List<string> StartGame(string inputCells, string diceOutput);
    }
}
