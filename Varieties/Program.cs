using System;

namespace Varieties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start play with culture example!");
            new PlayWithCulture().Demo();
            Console.WriteLine("End of play with culture example!");

            Console.WriteLine("Start reference type example!");
            var myCar = new Car { Name = "MyCarName" };
            new ReferenceTypes().ChangeCarName(myCar);
            Console.WriteLine(myCar.Name);
            Console.WriteLine("End of reference type example!");

            Console.WriteLine("Start params example!");
            var t1 = new TestClass();
            var t2 = new TestClass();
            new ParamsKeyword().Example(t1, t2);
            Console.WriteLine("End of params example!");

            Console.ReadKey();
        }
    }
}
