using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEightFeatures.AsyncStreams
{
    public class AsyncStream
    {
        public async IAsyncEnumerable<int> GetSequence()
        {
            for (int i = 0; i < 21; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
    }
}
