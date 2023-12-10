using SwordDamageTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalculatorConsoleApp
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage(RollDice());

            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                char input = Console.ReadKey().KeyChar;

                if (input != '0' && input != '1' && input != '2' && input != '3')
                    return;
                swordDamage.Roll = RollDice();
                swordDamage.Magic = (input == '1' || input == '3');
                swordDamage.Flaming = (input == '2' || input == '3');

                Console.WriteLine("\nRolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP\n");
            }
        }
        private static int RollDice()
        {
            return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
        }
        
    }
}
