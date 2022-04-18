using MandatoryAssignLib;
using MandatoryAssignLib.Interfaces;


namespace WeaponFactory.Weapons
{
    /// <summary>
    /// Base class for all weapons
    /// </summary>
    public abstract class WeaponBase :AttackItem
    {
        public abstract int  Damage { get; set; }
        public abstract int Range { get; set; }
        public abstract string description { get; set; }

        public override string ToString()
        {
            return $"{Damage}, Hit points  {Range} Range";
        }
    }
}
