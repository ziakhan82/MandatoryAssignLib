using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WeaponFactory.Weapons;

namespace MandatoryAssignLib.Weapons
{
    public class Phaser : WeaponBase
    {
        public string Name { get; set; }
        public override int Damage { get; set; }
        public override int Range { get; set;}
        public override string description { get; set; }
        public bool Lootable { get; set; } = true;
        public bool Removable { get; set; } = true;

      

        public Phaser( string name )
        {
            this.Name = name;
          

        }


    }
}
