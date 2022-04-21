namespace MandatoryAssignLib.Weapons
{
    public class Phaser : AttackItem
    {
        

        public override int HitPoints
        {
            get
            {
                return 15;
            }
        }

        public override string description => "Best Phaser";

        public override int Range => 15;

        public Phaser()
        {
                
        }

        public Phaser(string name):base(name)
        {
                
        }
    }
}
