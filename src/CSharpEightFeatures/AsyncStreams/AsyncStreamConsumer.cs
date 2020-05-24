using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEightFeatures.AsyncStreams
{
    public class AsyncStreamConsumer
    {
        public async Task Consume()
        {
            var asyncStream = new AsyncStream();
            await foreach(var number in asyncStream.GetSequence())
            {
                Console.WriteLine($"{DateTime.Now} got number: {number}");
            }
        }
    }
}
