using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //CheckRemovingStringsFromList();

            //RemoveDuringIteration();
            CheckConcurrentDictionary();
            Console.ReadKey();
        }

        static void CheckRemovingStringsFromList()
        {
            var testList = new List<string> { "one", "two", "three" };
            Console.WriteLine(testList.Count);
            testList.Remove("one");
            Console.WriteLine(testList.Count);
        }

        static void RemoveDuringIteration()
        {
            var testList = new List<string> { "one", "two", "three", "four", "five" };
            for (int i = 0; i < testList.Count; i++)
            {
                Console.WriteLine(testList[i]);
                if (i == 1)
                    testList.Remove("three");
            }

        }

        static void CheckConcurrentDictionary()
        {
            var testDict = new ConcurrentDictionary<string, bool>();
            testDict.TryAdd("one", true);
            testDict.TryAdd("two", true);
            testDict.TryAdd("three", true);
            testDict.TryAdd("four", true);

            for (int i = 0; i < testDict.Count; i++)
            {
                testDict.TryRemove("three", out var removed);
                Console.WriteLine(testDict.Keys.ElementAt(i));
            }

        }
    }
}
