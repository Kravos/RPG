using System;
using System.Reflection;

namespace RPG
{
    public class Rival
    {
        public string Rivalname;
        private readonly int HpMax = 1500;
        private readonly int DpMax = 500;
        private readonly int _healthPoints = 1500;

        public int HealthPoints
        { get; set; }

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
            set
            {
                _multiplier = value;
                HealthPoints = _healthPoints * _multiplier;
            }
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
            Restore();
            Strength = 50;
            Dodge = 20;
            Multiplier = 1;
            Reward = 100;
        }

        public void Restore()
        {
            HealthPoints = HpMax;
            DefensePoints = DpMax;
        }

        /*public void FightStats()
        {
            HealthPoints = HpMax;
            DefensePoints = DpMax;
            HealthPoints += DefensePoints / 2;
            HealthPoints *= Multiplier;
        }*/
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
    }
}