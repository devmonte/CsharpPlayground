using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndMore
{
    public class C : B
    {
        public new void Show()
        {
            Console.WriteLine("C.Show!");
        }
    }
}
