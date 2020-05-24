using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEightFeatures.NullableReferenceTypes
{
    public static class NullExample
    {
        public static class Demo
        {
            public static List<string> Test;
        }

        public static void Show()
        {
            Demo.Test = null;
            

        }

        private static void Iterate(List<string> toIterate)
        {
            foreach (var c in toIterate)
            {
                Console.WriteLine(c);
            }
        }

    }
}
