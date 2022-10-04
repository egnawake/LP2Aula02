using System;

namespace ClassVsStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1, p2;

            p1 = new Player { Health = 150, Armor = 20 };
            p2 = p1;

            Console.WriteLine("Player 1");
            ShowPlayer(p1);
            Console.WriteLine("Player 2");
            ShowPlayer(p2);
            Console.WriteLine("");

            p1.Health = 60;
            Console.WriteLine("Changed P1 health");
            Console.WriteLine("");

            Console.WriteLine("Player 1");
            ShowPlayer(p1);
            Console.WriteLine("Player 2");
            ShowPlayer(p2);
            Console.WriteLine("");
        }

        private static void ShowPlayer(Player p)
        {
            Console.WriteLine($"Health: {p.Health} | Armor: {p.Armor}");
        }

        private static void DoubleHealth(Player p)
        {
            p.Health = p.Health * 2;
        }
    }
}
