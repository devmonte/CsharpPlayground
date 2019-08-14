using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEightFeatures.DisposableRefStruct
{
    public class DisposableRefStructExample
    {
        public void Show()
        {
            using var disposableStruct = new DisposableRefStruct();
        }
    }
}
