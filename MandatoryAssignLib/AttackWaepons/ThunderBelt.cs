using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignLib.Interfaces;

namespace MandatoryAssignLib.Weapons
{
    public class ThunderBelt : DefenceItem
    {
        public override string Name { get; set; }

        public ThunderBelt(string name):base(name)
        {
           

        }

        public override int Damage => 10;

        public override string Description => "Best belt";
    }
}