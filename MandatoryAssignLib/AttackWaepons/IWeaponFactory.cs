using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignLib.Interfaces
{
   public interface IWeaponFactory
    {
        /// <summary>
        /// how we create an attack weapons
        /// </summary>
        /// <param name="type">AttackWeapons type that we have in our enum</param>
        /// <returns></returns>


        IWeapon Create(AttackWeapons type);

    }

}
