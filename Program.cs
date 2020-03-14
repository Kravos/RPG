using System;
using static RPG.Character;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menue
            Console.WriteLine("Welcome to my RPG");
            
            
            Console.WriteLine("---- Menue ----");
            Console.WriteLine("Enter one of the following options\n");
            Console.WriteLine("'create' - to create a new character.");
            Console.WriteLine("'exit' - to leave.\n");

            var menueInput = Console.ReadLine();
            if (menueInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
            else if (menueInput.Equals("Create", StringComparison.OrdinalIgnoreCase))
            {
                
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
                return;
            }
            
            //New object 
            var player = new Character();
            //Nickname
            Console.WriteLine("Please enter your Nickname:");
            var nicknameInput = Console.ReadLine();
            player.Nickname = nicknameInput;

            //Class
            Console.WriteLine("\nPlease enter your class! Choose between: Human, Monster and Mystic");

            player.Race = Console.ReadLine();
            String[] classes = {"Human" , "Monster" , "Mystic"};
            
            if (player.Race.Equals(classes[0] , StringComparison.OrdinalIgnoreCase))
            {
                player.Race = classes[0];
            }
            else if (player.Race.Equals(classes[1], StringComparison.OrdinalIgnoreCase) )
            {
                player.Race = classes[1];
            }
            else if (player.Race.Equals(classes[2], StringComparison.OrdinalIgnoreCase))
            {
                player.Race = classes[2];
            }
            else
            {
                Console.WriteLine("\nPlease choose one of the given classes.");
                return;
            }
            
            //Standard values
            player.Dodge = 0;
            player.Money = 0;
            player.Strength = 100;
            player.HealthPoints = 1000;
            player.DefensePoints = 1000;
            player.Experience = 0;
            player.Level = 1;
           
            
            //Outputs
            /*
            Console.WriteLine("\nYour Nickname is: "+ player.Nickname);
            Console.WriteLine("Your character is a "+classInput);
            Console.WriteLine("Dodge: " + player.Dodge + "\nMoney: " + player.Money + "$" + "\nStrength: " + player.Strength + "\nHP: " + player.HealthPoints + "\nDP: " + player.DefensePoints + "\nLevel: " + player.Level + "(" + player.Experience + "EXP)");
            */
            player.Creation();

        }
    }
}    