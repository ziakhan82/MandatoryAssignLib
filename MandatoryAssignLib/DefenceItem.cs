using MandatoryAssignLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignLib
{
  public abstract  class DefenceItem :WorldObject,IDefenceWeapons
    {

        public abstract string Name { get; set; }
        public abstract int Damage { get;  }
        public abstract string Description  { get;  }

        public DefenceItem()
        {
                
        }

        public DefenceItem(string Name)
        {
            this.Name = Name;
        }

        public override string ToString()
        {
            return $"{Name}:{Description},dealing{Damage} damage points";
        }
    }
}
