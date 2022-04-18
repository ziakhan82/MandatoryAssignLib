using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponFactory.Weapons;

namespace MandatoryAssignLib.Weapons
{
    public class TazerKnuckles : WeaponBase
    {
        
        public string Name { get; set; }
        public override int Damage { get; set; }
        public override int Range { get; set; }
        public bool Lootable { get; set; } = true;
        public bool Removable { get; set; } = true;
        public override string description { get; set; }


        public TazerKnuckles(string name, Position position)
        {
            this.Name = name;
           

        }

    }
    
}
