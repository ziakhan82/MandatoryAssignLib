using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignLib.Interfaces;

namespace MandatoryAssignLib.Weapons
{
   public class Cursed_Helmet:DefenceWeaponBase
    {
        public string Name { get; set; }
      //  public override int Damage { get; set; }

        public bool Lootable { get; set; } = true;
        public bool Removable { get; set; } = true;

     

        public Cursed_Helmet(string name)
        {
            this.Name = name;
          
        }
    }
}
    

