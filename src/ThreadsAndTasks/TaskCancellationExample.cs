using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsAndTasks
{
    public class TaskCancellationExample
    {
        public void Demonstrate() //not working as expected, checking token should be done directly
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            Task exampleTask = new Task(async () =>
            {
                do
                {
                    Console.WriteLine("Doing something!");
                    await Task.Delay(TimeSpan.FromSeconds(1));
                } while (true);
            }, cancellationTokenSource.Token);

            exampleTask.Start();
            Task.Delay(TimeSpan.FromSeconds(20)).Wait();
            Console.WriteLine("Cancelling!");
            cancellationTokenSource.Cancel();
        }


    }
}
