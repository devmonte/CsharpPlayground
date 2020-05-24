using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CovariantMover<T> : IMovementableCovariant<T> where T : new()
    {
        public T Move(string destination)
        {
            Console.WriteLine(":)");
            return new T();
        }
    }
}
