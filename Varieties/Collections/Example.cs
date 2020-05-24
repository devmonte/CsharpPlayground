using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    public class Example
    {
        public static void CheckRemovingStringsFromList()
        {
            var testList = new List<string> { "one", "two", "three" };
            Console.WriteLine(testList.Count);
            testList.Remove("one");
            Console.WriteLine(testList.Count);
        }

        public static void RemoveDuringIteration()
        {
            var testList = new List<string> { "one", "two", "three", "four", "five" };
            for (int i = 0; i < testList.Count; i++)
            {
                Console.WriteLine(testList[i]);
                if (i == 1)
                    testList.Remove("three");
            }

        }

        public static void CheckConcurrentDictionary()
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

        public static void CheckGroupByLinq()
        {
            var t1 = new Test { Id = 1, Name = "ABC" };
            var t2 = new Test { Id = 1, Name = "ABC" };
            var t3 = new Test { Id = 2, Name = "ABCD" };
            var t4 = new Test { Id = 2, Name = "ABCD" };

            var list = new List<Test> { t1, t2, t3, t4 };


            var filterOut = list.GroupBy(x => x.Id)
                .Select(x => x.First())
                .ToList();
        }

        public class Test
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
