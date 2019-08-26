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



            Console.ReadKey();
        }
    }
}
