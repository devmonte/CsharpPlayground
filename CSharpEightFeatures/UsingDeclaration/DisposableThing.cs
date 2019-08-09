using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEightFeatures.UsingDeclaration
{
    public class DisposableThing : IDisposable
    {

        public string GetSomeValue() => "Something useful.";

        public void Dispose()
        {
            Console.WriteLine("Disposing!");
        }
    }
}
