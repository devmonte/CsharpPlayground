using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class StandardMover<T> : IMovementable<T> where T : Creature
    {
        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
