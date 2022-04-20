using MandatoryAssignLib.Interfaces;
using MandatoryAssignLib.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignLib.Factories
{
    /// <summary>
    /// Weapon factory class for defence weapons.
    /// </summary>
    public class WeaponFactoryMedieval : WeaponsFactoryForDefence
    {
        public WeaponFactoryMedieval()
        {
                
        }
        /// <summary>
        /// here we create the defence weapons
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IDefenceWeapons WeaponsFactoryForDefence.Create(DefenceWeapons type)
        {
            if (type == DefenceWeapons.Wearable) return new Cursed_Helmet("Cursed_Helmet");
            if (type == DefenceWeapons.shields) return new Athena_s_Shield("Athena_s_Shield");
            if (type == DefenceWeapons.Wearable) return new ThunderBelt("ThunderBelt");

            throw new ArgumentException($"WeaponFactoryMedieval - no class available for weapon type {type}");
        }

    
        
    }
}