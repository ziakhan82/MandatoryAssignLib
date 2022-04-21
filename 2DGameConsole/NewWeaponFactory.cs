using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignLib.Factories;
using MandatoryAssignLib.Interfaces;

namespace _2DGameConsole
{
   public class NewWeaponFactory:IWeaponFactory
    {
        
              public IWeapon Create(AttackWeapons type)
        {
            // change the name of weapon
            if (type == AttackWeapons.Melee) return new NewWeapon("New Weapon");
            

            throw new ArgumentException($"WeaponFactoryFuture - no class available for weapon type {type}");
        }
        }
    }

