using System;
using System.Net.Mime;

namespace RPG
{
    public class Menu
    {
        public enum StartCommandType
        {
            Create = 1,
            Exit = 2,
            Fight = 3,
            Shop = 4
        }
        public enum RepeatCommandType
        {
            Exit = 1,
            Fight = 2,
            Shop = 3
        }

        public static void StartMenu()
        {
            Console.WriteLine(
                "Welcome to my RPG\n\n ---- Menu ----\n Enter one of the following options:\n'create' - to create a new character.\n'exit' - to leave.");
            bool repeatStartMenu = true;
            while (repeatStartMenu)
            {
                var startMenuInput = Console.ReadLine();
                if (startMenuInput != null)
                {
                    startMenuInput = startMenuInput.ToLower();
                    StartCommandType resultCommand;
                    Enum.TryParse(startMenuInput, true, out resultCommand);
                    switch (resultCommand)
                    {
                        case StartCommandType.Create:
                            repeatStartMenu = false;
                            break;
                        case StartCommandType.Exit:
                            Environment.Exit(0);
                            return;
                        case StartCommandType.Fight:
                            //soon
                            break;
                        case StartCommandType.Shop:
                            //soon
                            break;
                        default:
                            Console.WriteLine("Please use one of the given menu options.");
                            break;
                    }
                }
            }
        }

        public static void RepeatMenu(Character player, Rival enemy)
        {
            Console.WriteLine(
                "\n What is your next step?\n" +
                "Use Fight to fight again\n" +
                "Use Shop to purchase something\n" +
                "Use Exit to Quit.\n"
            );
           
            bool repeatRepeatMenu = true;
            while (repeatRepeatMenu)
            {
                var repeatMenuInput = Console.ReadLine();
                if (repeatMenuInput != null)
                {
                    repeatMenuInput = repeatMenuInput.ToLower();
                    RepeatCommandType resultCommand;
                    Enum.TryParse(repeatMenuInput, true, out resultCommand);
                    switch (resultCommand)
                    {
                        case RepeatCommandType.Exit:
                            Environment.Exit(0);
                            return;
                        case RepeatCommandType.Fight:
                            repeatRepeatMenu = false;
                            Fight.Fighting(player, enemy);
                            break;
                        case RepeatCommandType.Shop:
                            repeatRepeatMenu = false;
                            //soon
                            break;
                        default:
                            Console.WriteLine("Please use one of the given menu options.");
                            break;
                    }
                }
            }
        }
    }
}