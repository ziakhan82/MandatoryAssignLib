using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignLib.Interfaces
{
    public abstract class DefenceWeaponBase :DefenceItem 
    {
       // public abstract int Damage { get; set; }

        public override string ToString()
        {
            return $"{Damage},reduced Hit points";
        }
    }
}
