
using System;
using System.Collections.Generic;

namespace Generics
{
    class Example
    {
        static void Show(string[] args)
        {
            Console.WriteLine("Let's poke around variance!");

            IEnumerable<Creature> baseCollection = new List<Animal>();
            baseCollection = new List<Mammal>();

            //IMovementable<Animal> mover = new StandardMover<Mammal>();
            IMovementableCovariant<Animal> covMover = new CovariantMover<Mammal>();
            IMovementableContravariant<Animal> contrMover = new ContravariantMover<Creature>();

        }
    }
}
