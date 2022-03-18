using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarantinoObserversLibrary
{
    public class CombatMenu
    {
        public static int BattleMenu()
        {
            //declaring variables
            int randomDamage = 0;

            //creating random number generator
            Random randomNum = new Random();

            //displaying battle messages
            randomDamage = randomNum.Next(20);
            if (randomDamage > 10)
                Console.WriteLine("BRUTAL! You did " + randomDamage + " Damage!");
            else
                Console.WriteLine("Pow! You did " + randomDamage + " Damage.");

            //returning damage percentage
            return randomDamage;
        }
    }
}
