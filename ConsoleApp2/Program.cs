using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            var name = Console.ReadLine();
            Console.Write("Enter your age:");
            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.Write("Enter your birhday:");
            var birthday = Console.ReadLine();
            Console.WriteLine("Your birthday is {0}", birthday);

            Console.ReadKey();
        }
    }
}
