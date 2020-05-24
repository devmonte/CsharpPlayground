using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varieties
{
    public class StringImmutability
    {
        public void Show()
        {
            string test = "TestValue";
            test = "AnotherValue"; //it's OK, but new object(array) is created
            //test[0] = 'z';  cause error, it's readonly 
        }
    }
}
