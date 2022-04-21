using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignLib;
using MandatoryAssignLib.Interfaces;

namespace _2DGameConsole
{
    class NewWeapon:AttackItem,IWeapon
    {
        //public override string Name { get; set; }

        public override int HitPoints => 100;

        public override string description => "Kill enemy with only  one hit";

        public override int Range => 15;

        public NewWeapon()
        {
            
        }

        public NewWeapon(string name):base(name)
        {
            
        }
    }
}
