using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignLib.Interfaces;

namespace MandatoryAssignLib
{
   public class AttackItem:WorldObject,IWeapon
    {

        public int HitPoints { get; set; }

        public string Name  { get; set; }

        public int Damage { get; set; }
        public int Range { get; set; }
        public string description { get; set; }
    }
}
