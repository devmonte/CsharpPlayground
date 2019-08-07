#nullable enable
using System;

namespace CSharpEightFeatures.NullableReferenceTypes
{
    public class NullableReference
    {
        private string _firstSentence;
        private string? _secondSentence;



        public void TryNullable()
        {
            _firstSentence = null;
            _secondSentence = null;
            string thirdSentence = null;

            Console.WriteLine(_firstSentence.Length);
            Console.WriteLine(_secondSentence.Length);
            Console.WriteLine(thirdSentence.Length);


        }
    }
}
