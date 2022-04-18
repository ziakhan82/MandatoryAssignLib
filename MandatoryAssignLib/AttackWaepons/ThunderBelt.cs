﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignLib.Interfaces;

namespace MandatoryAssignLib.Weapons
{
   public class ThunderBelt :DefenceWeaponBase
    {
        public string Name { get; set; }
       // public override int Damage { get; set; }

        public bool Lootable { get; set; } = true;
        public bool Removable { get; set; } = true;

        

        public ThunderBelt(string name)
        {
            this.Name = name;
          
            this.Damage = -30;
            

        }
    }
}