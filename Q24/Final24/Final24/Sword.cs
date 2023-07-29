using System;
using System.Collections.Generic;
using System.Text;

namespace Final24
{
    internal class Sword : Weapon
    {
        public Sword() : base("Sword", 3)
        {
        }

        public override double CalculateDamage(int playerLevel, int diceRoll)
        {
            if (playerLevel >= 2)
                return base.CalculateDamage(playerLevel, diceRoll) * (1 + (playerLevel - 1) * 0.4); // Magic bonus for player levels 2 and above
            else
                return base.CalculateDamage(playerLevel, diceRoll);
        }
    }
}
