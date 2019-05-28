using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEightFeatures.PatternMatchingTypes;

namespace CSharpEightFeatures
{
    public class PatternMatching
    {
        public void TryPatternMatching()
        {

        }

        private void SwitchFromCSharpSeven(Animal animal)
        {
            switch (animal)
            {
                case Dog dog:
                    Console.WriteLine(dog.GetVoice);
                    break;
                case Cat cat:
                    Console.WriteLine(cat.GetVoice);
                    break;
            }
        }

        private void NewSwitch(Animal animal)
        {
            var voice = animal switch
            {
                Cat _ => "Its a cat!",
                _ => "Not a cat!"
            };
        }
    }
}
