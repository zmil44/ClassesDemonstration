/*Zachary Miller
 * 12/6/2017
 * assignment 5.2
 * The purpose of this program is to create two instances of the girl scout class and display the name, troop number, and dues owed
 * DemoScouts.cs
 * Bellevue University
 */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt_5._2
{
    class DemoScouts
    {
        static void Main(string[] args)
        {
            GirlScout girl1 = new GirlScout();
            GirlScout girl2 = new GirlScout();
            girl1.SetScoutName("Kelly");
            girl1.SetTroopNumber(66);
            girl1.SetDues(125.50);
            girl2.SetScoutName();
            girl2.SetTroopNumber();
            girl2.SetDues();

            Console.WriteLine(GirlScout.motto);
            Console.WriteLine("{0} of Troop number {1} owes ${2} in dues.", girl1.GetName(), girl1.GetTroop(), girl1.GetDues());
            Console.WriteLine("{0} of Troop number {1} owes ${2} in dues.", girl2.GetName(), girl2.GetTroop(), girl2.GetDues());
            Console.ReadLine();
        }
    }
}
