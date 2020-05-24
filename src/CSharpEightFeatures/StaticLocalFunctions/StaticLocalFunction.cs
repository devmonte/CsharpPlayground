using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEightFeatures.StaticLocalFunctions
{
    public class StaticLocalFunction
    {
        public int DoSomeCalculation(int a, int b)
        {
            return LocalSum();
            int LocalSum() => a + b;
        }

        public int DoSomeCalculationWithStaticLocalFunc(int a, int b)
        {
            return LocalSum(a, b);
            static int LocalSum(int x, int y) => x + y;
        }
    }
}
