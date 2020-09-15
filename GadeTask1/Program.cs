using System;

namespace GadeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (!(Console.KeyAvailable && Console.ReadKey(true).Key != ConsoleKey.UpArrow))
            //{
            //    Console.WriteLine("It works");
            //}
            ConsoleKeyInfo x = new ConsoleKeyInfo();
            while (x.KeyChar != 'w')
            {
                x = Console.ReadKey();
            }
            Console.Read();
        }
    }
}
