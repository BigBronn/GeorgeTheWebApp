using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string Bob = "Bob";
            string Tom = "Tom";
            int HitPointsBob = 105;
            int HitPointsTom = 90;
            int ArmorClassBob = 15;
            int ArmorClassTom = 18;
            int BaseAttackBob = 8;
            int BaseAttackTom = 7;
            
            while (true)
            {//Bob's Attack
                Console.WriteLine("Please enter the attack roll for Bob.");
                int Attackroll = int.Parse(Console.ReadLine());
                int BobAttack = Attackroll + BaseAttackBob;
                if (BobAttack >= ArmorClassTom)
                {//Bob's Damage
                    Console.WriteLine("Please enter Bob's damage.");
                    int BobDamage = int.Parse(Console.ReadLine());
                    HitPointsTom = HitPointsTom - BobDamage;
                    // Tom's New Health total
                    Console.WriteLine(string.Concat("Tom's HP is now ", HitPointsTom));
                }
                else
                {// Bob's Miss
                    Console.WriteLine(@"
______       _     _             _   _             _                _                  _ 
| ___ \     | |   ( )           | | | |           | |              (_)                | |
| |_/ / ___ | |__ |/ ___    __ _| |_| |_ __ _  ___| | __  _ __ ___  _ ___ ___  ___  __| |
| ___ \/ _ \| '_ \  / __|  / _` | __| __/ _` |/ __| |/ / | '_ ` _ \| / __/ __|/ _ \/ _` |
| |_/ / (_) | |_) | \__ \ | (_| | |_| || (_| | (__|   <  | | | | | | \__ \__ \  __/ (_| |
\____/ \___/|_.__/  |___/  \__,_|\__|\__\__,_|\___|_|\_\ |_| |_| |_|_|___/___/\___|\__,_|
                                                                                         
                                                                                        
");
                }
                if (HitPointsTom <= -1)
                {
                    Console.WriteLine("Tom has died.");
                    break;
                }
                // Tom's Attack
                Console.WriteLine("Please enter the attack roll for Tom.");
                Attackroll = int.Parse(Console.ReadLine());
                int TomAttack = Attackroll + BaseAttackTom;
                if (TomAttack >= ArmorClassBob)
                {//Tom's Damage
                    Console.WriteLine("Please enter Tom's damage.");
                    int TomDamage = int.Parse(Console.ReadLine());
                    HitPointsBob = HitPointsBob - TomDamage;
                    // Bobs's New Health total
                    Console.WriteLine(string.Concat("Bob's HP is now ", HitPointsBob));
                }
                else
                {// Tom's Miss
                    Console.WriteLine(@"
 _____               _             _   _             _                _                  _ 
|_   _|             ( )           | | | |           | |              (_)                | |
  | | ___  _ __ ___ |/ ___    __ _| |_| |_ __ _  ___| | __  _ __ ___  _ ___ ___  ___  __| |
  | |/ _ \| '_ ` _ \  / __|  / _` | __| __/ _` |/ __| |/ / | '_ ` _ \| / __/ __|/ _ \/ _` |
  | | (_) | | | | | | \__ \ | (_| | |_| || (_| | (__|   <  | | | | | | \__ \__ \  __/ (_| |
  \_/\___/|_| |_| |_| |___/  \__,_|\__|\__\__,_|\___|_|\_\ |_| |_| |_|_|___/___/\___|\__,_|
                                                                                                                              
");
                }
                if (HitPointsBob <= -1)
                {
                    Console.WriteLine("Bob has died.");
                    break;
                }
                
            }

            Console.WriteLine("The combat has ended. To the vitor goes the spoils!");
            Console.ReadLine();


            //for(int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

        }
    }
}
