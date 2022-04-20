namespace MandatoryAssignLib.Weapons
{
    public class CrossBow : DefenceItem
    {
        public override string Name { get; set; }

        public override int Damage { get; }

        public override string Description { get; }

        public CrossBow()
        {
                
        }

        public CrossBow(string name):base(name)
        {
            
                
        }
    }

    
    }    

