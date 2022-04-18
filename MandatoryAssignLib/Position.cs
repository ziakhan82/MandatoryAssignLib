﻿using MandatoryAssignLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MandatoryAssignLib
{
  public  class Position:IPosition
    {
        public Position()
        {
                
        }
        public int X { get; set; }

        public int Y { get; set; }

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;

        }
    }
}
