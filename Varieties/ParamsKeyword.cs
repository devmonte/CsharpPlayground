using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varieties
{

    public class TestClass
    {
        public string Secret { get; set; }
    }

    public class ParamsKeyword
    {
        public void Example(params TestClass[] test)
        {

        }
    }
}
