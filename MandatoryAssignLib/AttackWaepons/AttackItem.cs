using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignLib.Interfaces;

namespace MandatoryAssignLib
{
   public abstract class AttackItem:WorldObject,IWeapon
    {
        /// <summary>
        /// Properties for the attack item
        /// </summary>

        //public abstract string Name  { get; set; }
        public abstract int HitPoints { get; }
        public abstract string description { get; }
        public abstract int Range { get;  }

        public AttackItem()
        {
            
        }
        /// <summary>
        /// Constructor with one parameter to intialize the name of attackItem
        /// </summary>
        /// <param name="name"></param>
        public AttackItem(string name)
        {
            this.Name = name;

        }
       

        public override string ToString()
        {
            return $"{Name}:{description},{HitPoints} hitPoints,Range{Range}";
        }
    }
}
