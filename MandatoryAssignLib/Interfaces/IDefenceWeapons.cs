using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignLib.Interfaces
{
    /// <summary>
    /// Interface segregation example .. one object shouldn't inherit allfunctions, but only the ones
    /// it reuires .. e.g. a weapon gets attack functions, a defence item gets defence functions
    /// It's also kind of separation of concerns
    /// </summary>
  public  interface IDefenceWeapons
    {
        public int Damage { get;  }
        public string Description  { get; }
    }
}
