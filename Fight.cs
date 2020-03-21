using System;
using System.Threading;

namespace RPG
{
    public class Fight
    {
        public static void fight(int PlayerHP, int RivalHP, int PlayerDP, int RivalDP, int PlayerStrength,
            int RivalStrength,
            int PlayerDodge, int RivalDodge, string PlayerName, string RivalName, int PlayerMoney)
        {
            PlayerHP = PlayerHP + PlayerDP / 2;
            RivalHP = RivalHP + RivalDP / 2;

            Random DodgeRand = new Random();
            while (PlayerHP > 0 && RivalHP > 0)
            {
                var RandomDodge = DodgeRand.Next(0, 100);
                if (RandomDodge > RivalDodge)
                {
                    RivalHP = RivalHP - PlayerStrength;
                    Console.WriteLine("\nUpdated stats:\n Your HP: " + PlayerHP + "\n Rival HP: " + RivalHP);
                }
                else
                {
                    Console.WriteLine("\nYour Rival dodged the attack.");

                }

                if (RandomDodge > PlayerDodge)
                {
                    PlayerHP = PlayerHP - RivalStrength;
                    Console.WriteLine("\nUpdated stats:\n Your HP: " + PlayerHP + "\n Rival HP: " + RivalHP);
                }
                else
                {
                    Console.WriteLine("\nYou dodged the attack.");
                }


                if (RivalHP <= 0)
                {
                    Console.WriteLine(PlayerName + " defeated " + RivalName + "! GG\n");
                    PlayerMoney += 100;
                    Console.WriteLine(PlayerName + " earned " + PlayerMoney + "$!");
                }
                else if (PlayerHP <= 0)
                {
                    Console.WriteLine(PlayerName + " got defeated by " + RivalName + "! Noob.");
                }

                Thread.Sleep(500);
            }
        }
    }
}