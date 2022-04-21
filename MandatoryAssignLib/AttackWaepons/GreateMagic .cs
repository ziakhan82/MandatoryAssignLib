namespace MandatoryAssignLib.Weapons
{
    public class GreateMagic : AttackItem
    {
        

        public override int HitPoints
        {
            get { return 25; }
        }

        public override string description
        {
            get { return "Greatest magic in existance"; }
        }

        public override int Range => 20;

        public GreateMagic()
        {
            
        }

        public GreateMagic(string name):base(name)
        {
            
        }
    }
}   

        



