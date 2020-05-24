using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEightFeatures.IndicesAndRanges
{
    public class IndicesAndRangesExample
    {
        private string[] _exampleStrings;

        public IndicesAndRangesExample()
        {
            _exampleStrings = new string[]
            {
                "A",
                "B",
                "C",
                "D",
                "E",
                "F",
                "G"
            };
        }

        public void Show()
        {
            Console.WriteLine(string.Join(",", _exampleStrings[..4]));
            Console.WriteLine(string.Join(",", _exampleStrings[1..4]));
            Console.WriteLine(string.Join(",", _exampleStrings[4..]));
            Console.WriteLine(string.Join(",", _exampleStrings[^3..]));
        }
    }
}
