using System;
using System.Collections.Generic;
using System.Text;

namespace Final24
{
    internal class Dagger : Weapon
    {
        public Dagger() : base("Dagger", 2)
        {
        }

        public override double CalculateDamage(int playerLevel, int diceRoll)
        {
            if (playerLevel >= 2)
                BaseDamage += (BaseDamage * 0.4);

            return base.CalculateDamage(playerLevel, diceRoll);
        }
    }
}
