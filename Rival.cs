using System;

namespace RPG
{
    public class Rival
    {
        public string Rivalname;
        public int HealthPoints;
        public int DefensePoints;
        public int Strength;
        public int Dodge;
        public int Multiplier;

        public Rival(string Rivalname)
        {
            this.Rivalname = Rivalname;
            this.HealthPoints = 1500;
            this.DefensePoints = 500;
            this.Strength = 50;
            this.Dodge = 20;
            this.Multiplier = 1;
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
            Console.WriteLine("Please enter your stage multiplier (min: 1 max: 100):  ");
            var multiplierInput = Console.ReadLine();
            int parsedMultiplierInput;
            if (multiplierInput != null)
            {
                parsedMultiplierInput = Int32.Parse(multiplierInput);
                if (parsedMultiplierInput > 0 && parsedMultiplierInput <= 100)
                {
                    Multiplier = parsedMultiplierInput;
                }
                else
                {
                    return;
                }
            }
        }

        public void Multiply()
        {
            
        }
    }
}