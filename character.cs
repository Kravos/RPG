using System;

namespace RPG
{
    public class Character
    {
        public string Nickname;
        public string Race;
        public int Money { get; set;  }
        public int HealthPoints { get; set; }
        public int DefensePoints { get; set; }
        public int Strength { get; set; }
        public int Dodge { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }


        public Character()
        {
            Money = 0;
            HealthPoints = 1000;
            DefensePoints = 1000;
            Strength = 100;
            Dodge = 20;
            Level = 1;
            Experience = 0;
        }
       
        public void Fight2(Character characterParameters)
        {
            
        }

        public void Creation()
        {
            Console.WriteLine("\nYour character information:\n");
            Console.WriteLine("Name: " + Nickname);
            Console.WriteLine("Race: " + Race);
            Console.WriteLine("Money: " + Money + "$");
            Console.WriteLine("HealthPoints: " + HealthPoints);
            Console.WriteLine("DefensePoints: " + DefensePoints);
            Console.WriteLine("Strength: " + Strength);
            Console.WriteLine("Dodge: " + Dodge);
            Console.WriteLine("Level: " + Level + " (Experience: " + Experience + "%)");
        }
    }
}