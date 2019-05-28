using System;
using System.Threading;

namespace ThreadsAndTasks
{
    class Program
    {
        private static readonly object Guard = new object();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Start {Thread.CurrentThread.ManagedThreadId}");
            var t1 = new Thread(DoSomethingImportant);
            var t2 = new Thread(DoSomethingImportant);

            t1.Start();
            t2.Start();

            Console.WriteLine("End of World!");
            Console.ReadKey();
        }

        static void DoSomethingImportant()
        {
            lock (Guard)
            {
                Console.WriteLine($"Important stuff, {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }

        }
    }
}
