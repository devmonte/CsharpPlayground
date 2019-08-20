using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varieties
{
    public class Monkey : Animal
    {
        public override void Move(string destination)
        {
            base.Move(destination);
            Console.WriteLine("Overriden!");
        }
    }
}
