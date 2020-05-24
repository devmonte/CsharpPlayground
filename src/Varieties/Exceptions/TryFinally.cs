using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class TryFinally
    {
        public void CheckTryFinally()
        {
            try
            {
                throw new ApplicationException("Upss..");
            }
            finally
            {
                Console.WriteLine("Finally!");
            }
        }
    }
}
