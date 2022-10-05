using System;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; set; }

        public override int Health => base.Health + XP;
        public override float Value => AttackPower + XP;

        public MilitaryUnit(int movement, int health, int attackPower)
            : base(movement, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public void Attack(Unit unit)
        {
            Console.WriteLine($"Unit dealt {AttackPower} damage");
        }

        public override string ToString()
        {
            return base.ToString() + $" | Power: {AttackPower} | XP: {XP}";
        }
    }
}

