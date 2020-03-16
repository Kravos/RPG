using System;

namespace RPG
{
    public class Character
    {
        public string Nickname;
        public string Race;
        public int Money;
        public int HealthPoints ;
        public int DefensePoints;
        public int Strength ;
        public int Dodge;
        public int Level;
        public int Experience;

        
        public Character(string Nickname, string Race)
        {
            this.Nickname = Nickname;
            this.Race = Race;
            this.Money = 0;
            this.HealthPoints = 1000;
            this.DefensePoints = 1000;
            this.Strength = 100;
            this.Dodge = 1;
            this.Level = 1;
            this.Experience = 0;
        }
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