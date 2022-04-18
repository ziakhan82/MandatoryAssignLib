using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignLib.Interfaces
{
   public interface WeaponsFactoryForDefence
    {
        /// <summary>
        /// how we create the defence  weapons
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>

        /// n
        IDefenceWeapons Create(DefenceWeapons type);
    }
}
