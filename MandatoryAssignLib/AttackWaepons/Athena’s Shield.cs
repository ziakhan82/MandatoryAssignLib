using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignLib.Interfaces;

namespace MandatoryAssignLib.Weapons
{
    public class Athena_s_Shield : DefenceItem
    {
        public override string Name { get; set; }


        public override int Damage
        {
            get
            {
                return 10;
            }
        }

        public override string Description
        {
            get
            {
                return "Best shield";
            }
        }

        public Athena_s_Shield()
        {
                
        }

        public Athena_s_Shield(string name):base(name)
        {
                
        }
    }
}
