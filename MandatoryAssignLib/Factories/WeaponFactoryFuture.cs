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
    /// Weapon factory class for futuristic weapons.inherite from the IWeaponFactory
    /// </summary>
    public class WeaponFactoryFuture : IWeaponFactory
    {

        /// <summary>
        /// method of type weapon type as its in enum
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IWeapon Create(AttackWeapons type)
        {
            // change the name of weapon
            if (type == AttackWeapons.Melee) return new TazerKnuckles("Tazer");
            if (type == AttackWeapons.Ranged) return new Phaser(name:"Ranged");
            if (type == AttackWeapons.Magic) return new GreateMagic(name:"Magic");

            throw new ArgumentException($"WeaponFactoryFuture - no class available for weapon type {type}");
        }
    }
}