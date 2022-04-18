using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignLib.Interfaces;

namespace MandatoryAssignLib.Weapons
{
    public class Athena_s_Shield : DefenceWeaponBase
    {
        public string Name { get; set; }
       // public override int Damage { get; set; }

        public bool Lootable { get; set; } = true;
        public bool Removable { get; set; } = true;

       // public Position Position { get; set; }

        public Athena_s_Shield(string name)
        {
            this.Name = name;
           //this.Position = position;

        }
    }
}
