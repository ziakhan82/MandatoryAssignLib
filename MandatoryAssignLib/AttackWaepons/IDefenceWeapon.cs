using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignLib.Weapons
{
    public  interface IDefenceWeapon
    {
       // public string Name { get; set; }

        public int ReducedHitPoints { get;  }
    }
}
