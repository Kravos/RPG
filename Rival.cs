using System;

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

        public Rival(string Rivalname)
        {
            this.Rivalname = Rivalname;
            HealthPoints = 1500;
            DefensePoints = 500;
            Strength = 50;
            Dodge = 20;
            Multiplier = 1;
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
            if (multiplierInput == null) return;
            parsedMultiplierInput = int.Parse(multiplierInput);
            if (parsedMultiplierInput > 0 && parsedMultiplierInput <= 100)
            {
                Multiplier = parsedMultiplierInput;
            }
            else
            {
                return;
            }
        }

        public void Multiply()
        {
            
        }
    }
}