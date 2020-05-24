using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndMore
{
    public class B : A
    {
        public override void Show()
        {
            Console.WriteLine("B.Show!");
        }
    }
}
