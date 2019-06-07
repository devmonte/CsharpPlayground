using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varieties
{
    public class PlayWithCulture
    {
        public void Demo()
        {
            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(6.66F);

            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pl-PL");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(6.66D);

        }
    }
}
