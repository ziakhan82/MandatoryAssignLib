using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignLib.Interfaces;

namespace MandatoryAssignLib.Weapons
{
    public class Cursed_Helmet : DefenceItem
    {
        public override string Name { get; set; }



        public override int Damage
        {
            get
            {
                return 5;
            }
        }

        public override string Description => "Best helmet";

        public Cursed_Helmet()
        {
                
        }

        public Cursed_Helmet(string name):base(name)
        {
            
        }
    }
}
    

