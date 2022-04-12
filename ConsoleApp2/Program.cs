using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Jane";
            byte Age = 27;
            bool Pet = true;
            double Shoes = 37.5;

            Console.WriteLine("Me name is " + MyName);
            Console.WriteLine("My age is " + Age);
            Console.WriteLine("Do i have a pet? " + Pet);
            Console.WriteLine("My she size is " + Shoes);
            Console.WriteLine("InitMaxValue {0}", int.MaxValue);
            Console.WriteLine("InitMinValue {0}", int.MinValue);
                        
            Console.ReadKey();
        }
    }
}
