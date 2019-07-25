using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsAndTasks
{
    public class AsyncNullReturn
    {
        public async Task Example()
        {
            try
            {
                await ReturnNull();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private Task ReturnNull()
        {
            TestNullClass nullTask = null;
            return nullTask?.SuperMethod();
        }


        class TestNullClass
        {
            public Task SuperMethod()
            {
                return Task.CompletedTask;
            }
        }
    }
}
