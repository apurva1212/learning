using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Model
{
   public class Board
    {
        public int InitialMoney { get; set; } = 5000;
        public List<Cell> Cells { get; set; }
    }
}
