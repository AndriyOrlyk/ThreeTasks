using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTask
{
    public class MergeSort
    {
        public int[] Sort(int[] arrayToSort)
        {
            if (arrayToSort.Length == 1)
                return arrayToSort;

            if (arrayToSort.Length == 2)
                return SortTwoElements(arrayToSort[0], arrayToSort[1]);

            var splitter = new ArraySplitter(arrayToSort);
            int[] splittedArrayA = splitter.GetFirstPart();
            int[] splittedArrayB = splitter.GetSecondPart();

            int[] sortedArrayA = Sort(splittedArrayA);
            int[] sortedArrayB = Sort(splittedArrayB);

            var merger = new Merger();
            return merger.Merge(sortedArrayA, sortedArrayB);
        }

        private int[] SortTwoElements(int firstElement, int secondElement)
        {
            var min = (Math.Abs(firstElement + secondElement) - Math.Abs(firstElement - secondElement)) / 2;
            var max = (Math.Abs(firstElement + secondElement) + Math.Abs(firstElement - secondElement)) / 2;
            return new[] { min, max };
        }
    }
}
