using System;

namespace Final24
{




    internal class Program
    {
        static void Main(string[] args)
        {
            int playerLevel = 3;
            Random random = new Random();
            int diceRoll = random.Next(1, 7);

            Weapon sword = new Sword();
            double swordDamage = sword.CalculateDamage(playerLevel, diceRoll);
            Console.WriteLine($"Sword dmg: {swordDamage}");

            Weapon arrow = new Arrow();
            double arrowDamage = arrow.CalculateDamage(playerLevel, diceRoll);
            Console.WriteLine($"Arrow dmg: {arrowDamage}");

            Weapon crossbow = new Crossbow();
            double crossbowDamage = crossbow.CalculateDamage(playerLevel, diceRoll);
            Console.WriteLine($"Crossbow dmg: {crossbowDamage}");

            Weapon whip = new Whip();
            double whipDamage = whip.CalculateDamage(playerLevel, diceRoll);
            Console.WriteLine($"Whip dmg: {whipDamage}");

            Weapon dagger = new Dagger();
            double daggerDamage = dagger.CalculateDamage(playerLevel, diceRoll);
            Console.WriteLine($"Dagger dmg: {daggerDamage}");

            Weapon staff = new Staff();
            double staffDamage = staff.CalculateDamage(playerLevel, diceRoll);
            Console.WriteLine($"Staff dmg: {staffDamage}");
        }
    }
}
