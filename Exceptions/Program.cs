using System;
using System.Threading;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AppDomain.CurrentDomain.FirstChanceException += (sender, eventArgs) =>
            {
                Console.WriteLine($"{sender}, {eventArgs}");
            };
            AppDomain.CurrentDomain.UnhandledException += (sender, eventArgs) =>
            {
                Console.WriteLine($"{sender}, {eventArgs}");
            };

            var tryFinallyCheck = new TryFinally();
            try
            {
                tryFinallyCheck.CheckTryFinally();
                //throw new NotImplementedException();
                var t = new Thread(() => throw new NotImplementedException());
                t.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
