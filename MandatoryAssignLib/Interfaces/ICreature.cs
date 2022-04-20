using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignLib
{
  public interface ICreature
    {
        public void HitOthercreature(Creature enemy);
        public void LootObjectsFromOthers(WorldObject worldObject);

        public void RecivedFromOtherCreature(int slaps);

        public bool isDead();

        //Single responsibility Principle using multiple interfaces

        interface IDead
        {
            public bool isDead();
        }
        interface ILootObjectsFromOthers{
            public void LootObjectsFromOthers(WorldObject worldObject);
        
            
        }





    }
}
