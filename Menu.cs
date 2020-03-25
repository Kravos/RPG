using System;

namespace RPG
{
    public class Menu
    {
        public enum CommandType
        {
            Create = 1,
            Exit = 2,
            Fight = 3,
            Shop = 4
        }
        public static void StartMenu()
        {

            Console.WriteLine(
                "Welcome to my RPG\n\n ---- Menu ----\n Enter one of the following options:\n'create' - to create a new character.\n'exit' - to leave.");
            bool repeatMenu = true;
            while (repeatMenu)
            {
                var menuInput = Console.ReadLine();
                if (menuInput != null)
                {
                    menuInput = menuInput.ToLower();
                    CommandType resultCommand;
                    Enum.TryParse(menuInput, true, out resultCommand);
                    switch (resultCommand)
                    {
                        case CommandType.Create:
                            repeatMenu = false;
                            break;
                        case CommandType.Exit:
                            return;
                        case CommandType.Fight:
                            //soon
                            break;
                        case CommandType.Shop:
                            //soon
                            break;
                        default:
                            Console.WriteLine("Please use one of the given menu options.");
                            repeatMenu = true;
                            break;
                    }
                }
            }
        }
    }
}