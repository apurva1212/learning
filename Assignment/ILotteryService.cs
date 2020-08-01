using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
  public  interface ILotteryService
    {
        void ProcessGame(Board gBoard, Player player);
    }
}
