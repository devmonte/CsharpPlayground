using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varieties
{
    public class Animal //base Class
    {
        public void Move()
        {
            Console.WriteLine("Moving...");
        }

        public void Move(int howLong)
        {
            Console.WriteLine("Moving..." + howLong);
        }

        public virtual void Move(string destination)
        {
            Console.WriteLine("Moving..." + destination);
        }

    }
}
