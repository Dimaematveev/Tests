using System;

namespace Tests1.CMD
{
    public class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void SayGoodBye()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Goodbye!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
