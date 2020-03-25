using System;
using System.Threading;

namespace RPG
{
    public class Fight
    {
        public static void Fighting(Character player, Rival enemy)
        {
            player.HealthPoints += player.DefensePoints / 2;
            enemy.HealthPoints += enemy.DefensePoints / 2;

            Random DodgeRand = new Random();
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
                    player.Money += 100;
                    Console.WriteLine(player.Nickname + " earned " + player.Money + "$!");
                }
                else if (player.HealthPoints <= 0)
                {
                    Console.WriteLine(player.Nickname + " got defeated by " + enemy.Rivalname + "! Noob.");
                }

                //Thread.Sleep(500);
            }
        }
    }
}