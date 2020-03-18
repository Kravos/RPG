using System;
using System.Threading;

namespace RPG
{
    public interface Fight
    {

        public static void fight(int PlayerHP, int RivalHP, int PlayerDP, int RivalDP, int playerStrength, int RivalStrength,
            int playerDodge, int rivalDodge, string PlayerName, string RivalName)
        {
            PlayerHP = PlayerHP +  PlayerDP / 2;
            RivalHP = RivalHP + RivalDP / 2;

            while (PlayerHP >= 0 && RivalHP >= 0)
            {
                RivalHP = RivalHP - playerStrength;
                PlayerHP = PlayerHP - RivalStrength;
                Console.WriteLine("\nUpdated stats:\n Your HP: "+ PlayerHP + "\n Rival HP: " + RivalHP);
                if (RivalHP <= 0)
                {
                    Console.WriteLine(PlayerName + " defeated " + RivalName +"! GG");
                } else if (PlayerHP <= 0)
                {
                    Console.WriteLine(PlayerName + " got defeated by " + RivalName + "! Noob.");
                }
                Thread.Sleep(500); 
            }
        }
    }
}