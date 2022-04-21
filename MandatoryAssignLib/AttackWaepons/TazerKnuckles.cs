namespace MandatoryAssignLib.Weapons
{
    public class TazerKnuckles : AttackItem
    {
        
        
            

        public override int HitPoints
        {
            get
            {
                return 60;
            }
        }

        public override string description
        {
            get
            {
                return "The best one";
            }
        }

       


        

        public override int Range  {
           get
           {
               return 10;

           }
        }

        public TazerKnuckles()
        {
            
        }

        public TazerKnuckles(string name):base(name)
        {
            
        }
    }
}  