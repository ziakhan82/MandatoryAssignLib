using System;
using System.Diagnostics;
using MandatoryAssignLib;
using MandatoryAssignLib.Factories;
using MandatoryAssignLib.Interfaces;
using Microsoft.VisualBasic;

namespace _2DGameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WeaponFactoryFuture weaponFactory = new WeaponFactoryFuture();
         var weapon=  weaponFactory.Create(AttackWeapons.Melee);
         Console.WriteLine(weapon);

         
         var weapon2 = weaponFactory.Create(AttackWeapons.Magic);
         Console.WriteLine(weapon2);

         Creature creature = new Creature();
         creature.isDead();
         Tracing.log(TraceEventType.Error,"you are dead");


        }
    }
}
