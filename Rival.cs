using System;
using System.Reflection;

namespace RPG
{
    public class Rival
    {
        public string Rivalname;
        public int HealthPoints { get; set; }
        public int DefensePoints { get; set; }
        public int Strength { get; set; }
        public int Dodge { get; set; }
        public int Multiplier { get; set; }
        public int Reward { get; set; }

        public Rival(string Rivalname)
        {
            this.Rivalname = Rivalname;
            HealthPoints = 1500;
            DefensePoints = 500;
            Strength = 50;
            Dodge = 20;
            Multiplier = 1;
            Reward = 100;
        }

        public void RivalInfo()
        {
            Console.WriteLine("\nRival information:\n");
            Console.WriteLine("Name: " + Rivalname);
            Console.WriteLine("HealthPoints: " + HealthPoints);
            Console.WriteLine("DefensePoints: " + DefensePoints);
            Console.WriteLine("Strength: " + Strength);
            Console.WriteLine("Dodge: " + Dodge);
            Console.WriteLine("Stage Multiplier: " + Multiplier);
        }

        public void Multiply(Rival enemy)
        {
            enemy.HealthPoints *= Multiplier;
            enemy.DefensePoints *= Multiplier;
            enemy.Strength *= Multiplier;
            enemy.Reward *= Multiplier;
            enemy.Dodge += Multiplier;
            if (enemy.Dodge >= 100)
            {
                enemy.Dodge = 99;
            }
        }
    }
}