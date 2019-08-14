using System;
using CSharpEightFeatures.DisposableRefStruct;

namespace CSharpEightFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World and C# 8.0!");

            Console.WriteLine("Using declaration example!");
            new UsingDeclaration.UsingDeclaration().UseUsingDeclaration();
            Console.WriteLine("End of using declaration example!");

            Console.WriteLine("Disposable ref struct example!");
            new DisposableRefStructExample().Show();
            Console.WriteLine("End of disposable ref struct example!");

        }
    }
}
