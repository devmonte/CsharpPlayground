using System;

namespace DelegatesAndLambdas
{
    class Program
    {
        public delegate void TestDelegate(string name);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestDelegate test = PrintName;
            test += PrintSecondName;
            test("Greg");
            test += (s) => { Console.WriteLine($"Hello {s}"); };
            test = (d) => { Console.WriteLine($"Hello {d}"); };
            test += _ => Console.WriteLine($"Hell yeah!");
            test("Tom!");

            Console.ReadKey();
        }

        static void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        static void PrintSecondName(string name)
        {
            Console.WriteLine(name);
        }

    }
}
