using System;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;

        public virtual int Health { get; set; }
        public abstract float Value { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move(Vector2 v)
        {
            Console.WriteLine($"Moved {movement} units");
        }

        public override string ToString()
        {
            return $"Health: {Health} | Value: {Value}";
        }
    }
}

