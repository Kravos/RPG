using System;
using System.Threading;

namespace RPG
{
    public class Fight
    {
        public static void Fighting(Character player, Rival enemy)
        {
            Console.WriteLine("\nPlease enter your stage multiplier (min: 1 max: 100):  ");
            var multiplierInput = Console.ReadLine();
            int parsedMultiplierInput;
            if (multiplierInput == null) return;
            parsedMultiplierInput = int.Parse(multiplierInput);
            if (parsedMultiplierInput > 0 && parsedMultiplierInput <= 100)
            {
                enemy.Multiplier = parsedMultiplierInput;
            }
            else
            {
                enemy.Multiplier = 1;
            }

            Console.WriteLine("Stage Multiplier set to: " + enemy.Multiplier);
            //enemy.Restore();
            player.HealthPoints += player.DefensePoints / 2;
            //enemy.FightStats();
            Thread.Sleep(1000);
            var DodgeRand = new Random();
            while (player.HealthPoints > 0 && enemy.HealthPoints > 0)
            {
                var RandomDodge = DodgeRand.Next(0, 100);
                if (RandomDodge > enemy.Dodge)
                {
                    enemy.HealthPoints -= player.Strength;
                    Console.WriteLine("\nUpdated stats:\n Your HP: " + player.HealthPoints + "\n Rival HP: " +
                                      enemy.HealthPoints);
                }
                else
                {
                    Console.WriteLine("\nYour Rival dodged the attack.");
                }

                RandomDodge = DodgeRand.Next(0, 100);
                if (RandomDodge > player.Dodge)
                {
                    player.HealthPoints -= enemy.Strength;
                    Console.WriteLine("\nUpdated stats:\n Your HP: " + player.HealthPoints + "\n Rival HP: " +
                                      enemy.HealthPoints);
                }
                else
                {
                    Console.WriteLine("\nYou dodged the attack.");
                }


                if (enemy.HealthPoints <= 0)
                {
                    Console.WriteLine(player.Nickname + " defeated " + enemy.Rivalname + "! GG\n");
                    player.Money += enemy.Reward;
                    Console.WriteLine(player.Nickname + " earned " + player.Money + "$!");
                }
                else if (player.HealthPoints <= 0)
                {
                    Console.WriteLine(player.Nickname + " got defeated by " + enemy.Rivalname + "! Noob.");
                }

                //Thread.Sleep(500);
            }

            Menu.RepeatMenu(player, enemy);
        }
    }
}