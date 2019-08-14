using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEightFeatures.DisposableRefStruct
{
    public ref struct DisposableRefStruct
    {
        public int X { get; set; }

        public void Dispose()
        {
            Console.WriteLine("Disposing ref struct!");
        }
    }
}
