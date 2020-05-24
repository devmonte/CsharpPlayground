using System;

namespace InheritanceAndMore
{
    class Example
    {
        static void Show(string[] args)
        {
            Console.WriteLine("Hello World!");

            A objA = new B();
            objA.Show();
            A objA2 = new C();
            objA2.Show();
            C objC = new D();
            objC.Show();

            Console.ReadKey();
        }
    }
}
