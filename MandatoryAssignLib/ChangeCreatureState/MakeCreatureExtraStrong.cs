using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignLib.Interfaces;

namespace MandatoryAssignLib.ChangeCreatureState
{
    class MakeCreatureExtraStrong:IWorldObject
    {
        public string ChangeCreatureState()
        {
            return "You have super strength!";
        }
    }
}
