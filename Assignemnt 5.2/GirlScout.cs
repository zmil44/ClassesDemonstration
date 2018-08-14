/*Zachary Miller
 * 12/6/2017
 * assignment 5.2
 * The purpose of this program is to set and return the values of dues owed, name, and troop number
 * GirlScout.cs
 * Bellevue University
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt_5._2
{
    class GirlScout
    {
        public const string motto = "To obey the Girl Scout Law.";
        public string name;
        public int troopNumber;
        public double duesOwed;

        public void SetScoutName()//default name
        {
            name = "default";
        }

        public void SetScoutName(String value)//set name of the girl scout
        {
            name = value;
        }

        public string GetName()//return the girl scouts name
        {
            return name;
        }
        public void SetTroopNumber()//default troop number
        {
            troopNumber = 0;
        }

        public void SetTroopNumber(int value)//set troop number
        {
            troopNumber = value;
        }

        public int GetTroop()//return troop number
        {
            return troopNumber;
        }
        
        public void SetDues()//default dues
        {
            duesOwed = 0.0;
        }

        public void SetDues(double value)//set dues owed
        {
            duesOwed = value;
        }
        public double GetDues()//return the amount of dues owed
        {
            return duesOwed;
        }
        
    }
}
