using System;
using System.Reflection;

namespace RPG
{
    public class Rival
    {
        public string Rivalname;

        private int _healthPoints;

        public int HealthPoints
        {
            get { return _healthPoints * Multiplier; }
            set { _healthPoints = value; }
        }

        private int _defensePoints;

        public int DefensePoints
        {
            get { return _defensePoints * Multiplier; }
            set { _defensePoints = value; }
        }

        private int _strength;

        public int Strength
        {
            get { return _strength * Multiplier; }
            set { _strength = value; }
        }

        private int _dodge;

        public int Dodge
        {
            get
            {
                if (_dodge >= 100)
                {
                    _dodge = 99;
                }

                return _dodge * Multiplier;
            }
            set { _dodge = value; }
        }

        private int _multiplier;

        public int Multiplier
        {
            get { return _multiplier; }
            set { _multiplier = value; }
        }

        private int _reward;

        public int Reward
        {
            get { return _reward * Multiplier; }
            set { _reward = value; }
        }

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

        /* public void Multiply(Rival enemy)
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
        } */
    }
}