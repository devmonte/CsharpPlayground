using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEightFeatures.UsingDeclaration
{
    public class UsingDeclaration
    {
        public void UseUsingDeclaration()
        {
            using var disposable = new DisposableThing();
            Console.WriteLine(disposable.GetSomeValue());
        }
    }
}
