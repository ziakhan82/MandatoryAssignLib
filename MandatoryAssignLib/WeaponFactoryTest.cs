using MandatoryAssignLib.Factories;
using MandatoryAssignLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignLib
{
    /// <summary>
    /// Class for invoking a test of the weapon factory classes..
    /// </summary>
    public class WeaponFactoryTest
    {
        public static void Run()
        {
            Console.WriteLine("Testing Medieval Weapon Factory");
            TestWeaponFactory(new WeaponFactoryMedieval());
            Console.WriteLine();

            Console.WriteLine("Testing Future Weapon Factory");
            TestWeaponFactory(new WeaponFactoryFuture());
            Console.WriteLine();
        }

        private static void TestWeaponFactory(IWeaponFactory factory)
        {
            IWeapon meeleWeapon = factory.Create(AttackWeapons.Melee);
            IWeapon rangedWeapon = factory.Create(AttackWeapons.Ranged);
            IWeapon magicWeapon = factory.Create(AttackWeapons.Magic);

            Console.WriteLine($"Meele Weapon: {meeleWeapon}");
            Console.WriteLine($"Ranged Weapon: {rangedWeapon}");
            Console.WriteLine($"Magic Weapon: {magicWeapon}");
        }
    }
}