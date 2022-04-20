using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignLib.Enums;
using MandatoryAssignLib.Interfaces;

namespace MandatoryAssignLib
{
  public class Creature:Position,ICreature
    {
        
        public int HitPoint { get; set; }
        public string Name { get; set; }
        public CreatureStateEnum CurrentStateEnum { get; set; }
        public List<CreatureStateEnum> CreatureStates { get; set; }
        public WorldObjectsEnum CurrentWorldObject { get; set; }
        public Dictionary<WorldObjectsEnum, IWorldObject> creatureStateWithWorldObj { get; }
        public Position PositionX { get; set; }
        public Position PositionY { get; set; }

        public Creature()
        {
                
        }

        public Creature(Position postionx,Position positionY,string name, CreatureStateEnum initialStateEnum = CreatureStateEnum.idle, WorldObjectsEnum initialStateWorldObject = WorldObjectsEnum.emptyHanded)
        {
            this.PositionX = postionx;
            this.PositionX = positionY;
            this.Name = name;
            CurrentStateEnum = initialStateEnum;
            CreatureStates = new List<CreatureStateEnum>();
            CurrentWorldObject = initialStateWorldObject;
            creatureStateWithWorldObj = new Dictionary<WorldObjectsEnum, IWorldObject>();

            


        }


        private List<DefenceItem> ListOFdefenceItems = new List<DefenceItem>();
        private List<AttackItem> ListOfattackItems = new List<AttackItem>();



        public void SetCreaturesStateWithWorldObj(WorldObjectsEnum state, IWorldObject behavior)
        {
            creatureStateWithWorldObj[state] = behavior;
        }
        public void ActBehavior()
        {
            if (creatureStateWithWorldObj.ContainsKey(CurrentWorldObject))
            {
                creatureStateWithWorldObj[CurrentWorldObject].ChangeCreatureState();
            }
            else
            {
                throw new Exception($"No behavior defined for state {CurrentWorldObject}");
            }
        }





        /// <summary>
        /// Calculates the points a creature gains when attacking their enemy.
        /// </summary>
        /// <param name="enemy"></param>
        public void HitOthercreature(Creature enemy)
        {
            var Totalattacks = ListOfattackItems.Sum(item => item.HitPoints);
            enemy.RecivedFromOtherCreature(Totalattacks);
        }
        /// <summary>
        /// Check if world object is removable.
        /// If it is, it allows a creature to keep it, and adds it to the corresponding list.
        /// </summary>
        /// <param name="worldObject"></param>
        public void LootObjectsFromOthers(WorldObject worldObject)
        {
            if (worldObject is AttackItem)
            {
                ListOfattackItems.Add(worldObject as AttackItem);
            }
            else if (worldObject is DefenceItem)
            {
                ListOFdefenceItems.Add(worldObject as DefenceItem);
            }
        }
        /// <summary>
        /// Calculates the points a creature loses when they get hit by their enemy.
        /// </summary>
        /// <param name="hit"></param>
        public void RecivedFromOtherCreature(int slaps)
        {
            var defence = ListOFdefenceItems.Sum(defenceItem => defenceItem.Damage);
            HitPoint -= (slaps - defence);
        }

        /// <summary>
        /// Checks if a creature is dead when their life points is equals to or less than 0.
        /// </summary>
        /// <returns></returns>
        public bool isDead()
        {
            Tracing.log(TraceEventType.Information, "YOU are dead");

            if (HitPoint is <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
