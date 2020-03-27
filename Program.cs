using System;


namespace RPG
{
    abstract class Program
    {
        public enum RaceType
        {
            Human = 1,
            Monster = 2,
            Mystic = 3
        }

        static void Main(string[] args)
        {
            //Menu
            Menu.StartMenu();

            //New object of Character
            var player = new Character();
            //Nickname
            Console.WriteLine("Please enter your Nickname:");
            var nicknameInput = Console.ReadLine();
            player.Nickname = nicknameInput;

            //race
            bool repeatRaceInput = true;
            while (repeatRaceInput)
            {
                Console.WriteLine("Please enter your race. Choose from Human, Monster or Mystic.");
                var raceInput = Console.ReadLine();
                raceInput = raceInput.ToUpper();
                RaceType resultRace;
                Enum.TryParse(raceInput, true, out resultRace);
                switch (resultRace)
                {
                    case RaceType.Human:
                        player.Race = "Human";
                        repeatRaceInput = false;
                        break;
                    case RaceType.Monster:
                        player.Race = "Monster";
                        repeatRaceInput = false;
                        break;
                    case RaceType.Mystic:
                        player.Race = "Mystic";
                        repeatRaceInput = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid race");
                        break;
                }
            }
            player.CharacterStats();
            
            //New object of Rival
            var enemy = new Rival("Yo Mama");

            enemy.RivalInfo();
            Fight.Fighting(player, enemy);
        }
        
    }
}

