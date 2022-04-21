using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignLib
{
   public class WorldObject:Position
    {
        public bool Lootable { get; set; }
        public string Name { get; set; }
        public bool Removable { get; set; }
        //public string Description { get; set; }


    }
}
