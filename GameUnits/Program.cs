using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit warrior = new MilitaryUnit(3, 20, 5);
            SettlerUnit settler = new SettlerUnit(2, 12);

            warrior.Move(new Vector2 { X = 4, Y = 2 });
            settler.Move(new Vector2 { X = 0, Y = 2 });

            Console.WriteLine(warrior);
            Console.WriteLine(settler);
        }
    }
}
