using MandatoryAssignLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignLib
{
  public  class DefenceItem :WorldObject,IDefenceWeapons
    {

        public string Name { get; set; }
        public int ReduceHitPoints { get; set; }
        public string Description  { get; set; }
        public int Damage { get;  set; }
    }
}
