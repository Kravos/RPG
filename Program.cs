using System;
using static RPG.Character;

namespace RPG
{
    class Program
    {
        public enum CommandType
        {
            Create = 1,
            Exit = 2
        }
        public enum RaceType
        {
            Human = 1,
            Monster = 2,
            Mystic = 3
        }
        static void Main(string[] args)
        { 
            //Menu
            Console.WriteLine(
                "Welcome to my RPG\n\n ---- Menu ----\n Enter one of the following options:\n'create' - to create a new character.\n'exit' - to leave.");
            
            var menuInput = Console.ReadLine();
            CommandType resultCommand;
            while (Enum.TryParse(menuInput, true, out resultCommand))
            {
                menuInput = menuInput.ToLower();
                Enum.TryParse(menuInput, true, out resultCommand);
                switch (resultCommand)
                {
                    case CommandType.Create:
                        break;
                    case CommandType.Exit:
                        return;
                    default:
                        Console.WriteLine("Please use one of the given menu options.");
                        break;
                }    
            }

            
            
            //New object of Character
            var player = new Character("", "");
            //Nickname
            Console.WriteLine("Please enter your Nickname:");
            var nicknameInput = Console.ReadLine();
            player.Nickname = nicknameInput;
            
            //race
            Console.WriteLine("Please enter your race. Choose from Human, Monster or Mystic.");
            var raceInput = Console.ReadLine();
            raceInput = raceInput.ToUpper();
            RaceType resultRace;
            Enum.TryParse(raceInput, true, out resultRace);
            switch (resultRace)
            {
                case RaceType.Human:
                    player.Race = "Human";
                    break;
                case RaceType.Monster:
                    player.Race = "Monster";
                    break;
                case RaceType.Mystic:
                    player.Race = "Mystic";
                    break;
                default:
                    Console.WriteLine("Please enter a valid race");
                    return;
            }
            
            player.Creation();
            //New object of Rival
            var enemy = new Rival("Yo Mama");
            
            enemy.RivalInfo();
            Console.WriteLine("Stage Multiplier set to: " + enemy.Multiplier);
        }
    }
}    