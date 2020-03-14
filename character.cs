using System;

namespace RPG
{
    public class Character
    {
        public string Nickname;
        public string Race;
        public int Money;
        public int HealthPoints;
        public int DefensePoints;
        public int Strength;
        public int Dodge;
        public int Level;
        public int Experience;

        public void Creation()
        {
            Console.WriteLine("\nYour character information:\n" );
            Console.WriteLine("Name: "+ Nickname);
            Console.WriteLine("Race: "+ Race);
            Console.WriteLine("Money: "+ Money + "$");
            Console.WriteLine("HealthPoints: "+ HealthPoints);
            Console.WriteLine("DefensePoints: "+ DefensePoints);
            Console.WriteLine("Strength: "+ Strength);
            Console.WriteLine("Dodge: "+ Dodge);
            Console.WriteLine("Level: "+ Level + " (Experience: "+ Experience +"%)");
        }
    }
}