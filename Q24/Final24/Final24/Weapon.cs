using System;
using System.Collections.Generic;
using System.Text;

namespace Final24
{
    internal class Weapon
    {
        public string Name { get; set; }
        public double BaseDamage { get; set; }

        public Weapon(string name, double baseDamage)
        {
            Name = name;
            BaseDamage = baseDamage;
        }

        public virtual double CalculateDamage(int playerLevel, int diceRoll)
        {
            double damageIncrease = GetDamageIncrease(playerLevel, diceRoll);
            double totalDamage = BaseDamage + (BaseDamage * damageIncrease / 100.0);
            return totalDamage;
        }

        protected double GetDamageIncrease(int playerLevel, int diceRoll)
        {
            double levelDamageIncrease = GetLevelDamageIncrease(playerLevel);
            double diceRollIncrease = GetDiceRollIncrease(diceRoll);
            return levelDamageIncrease + diceRollIncrease;
        }

        protected double GetLevelDamageIncrease(int playerLevel)
        {
            switch (playerLevel)
            {
                case 1: return 0;
                case 2: return 40;
                case 3: return 60;
                case 4: return 80;
                case 5: return 100;
                default: throw new ArgumentException("Invalid player level.");
            }
        }

        protected double GetDiceRollIncrease(int diceRoll)
        {
            switch (diceRoll)
            {
                case 1: return 0;
                case 2: return 20;
                case 3: return 30;
                case 4: return 40;
                case 5: return 50;
                case 6: return 60;
                default: throw new ArgumentException("Invalid dice roll.");
            }
        }
    }
}
