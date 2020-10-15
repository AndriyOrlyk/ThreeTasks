using System;
using System.Collections.Generic;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 4, 8, 34 };
            int[] arr2 = { 2, 5, 6, 8, 12, 42, 54 };
            List<int> list1 = new List<int>(arr1);

            List<int> list2 = new List<int>(arr2);
            list1.AddRange(list2);


            var mergeSorter = new MergeSort();
            var sortedArrray = mergeSorter.Sort(list1.ToArray());
            foreach (var i in sortedArrray)
                Console.Write(i + "\t");
            Console.ReadKey();
        }
    }
}
