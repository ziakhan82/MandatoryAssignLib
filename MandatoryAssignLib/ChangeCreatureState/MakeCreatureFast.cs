using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignLib.Interfaces;

namespace MandatoryAssignLib.ChangeCreatureState
{
    class MakeCreatureFast :IWorld
    {
        public string ChangeCreatureState()
        {
            return "You have lightning speed!";
        }
    }
}
