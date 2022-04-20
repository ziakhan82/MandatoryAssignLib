using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignLib.Interfaces
{
    /// <summary>
    /// The Iweapons represents the attack weapons 
    /// </summary>
   public interface IWeapon
    {
       int  HitPoints{ get; }
 

        string description { get; }

    }



}
