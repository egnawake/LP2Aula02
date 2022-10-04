using System;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit(int movement, int health)
            : base(movement, health)
        {
        }

        public void Settle(Vector2 v)
        {
            Console.WriteLine("Settler founded a new city");
        }
    }
}

