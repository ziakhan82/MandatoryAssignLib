namespace MandatoryAssignLib.Weapons
{
    public class Dagger : AttackItem
    {
       
        


            public override int HitPoints
        {

            get { return 10; }
        }


        public override string description
        {
            get { return "Dangerous Dagger"; }

        }

        public override int Range
        {
            get { return 20; }
        }

        public bool Lootable { get; set; } = true;
        public bool Removable { get; set; } = true;




    }
}