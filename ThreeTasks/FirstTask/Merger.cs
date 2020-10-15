using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTask
{
    public class Merger
    {
        public int[] Merge(int[] sortedArrayA, int[] sortedArrayB)
        {
            var mergedArray = new int[sortedArrayA.Length + sortedArrayB.Length];
            var visitableArrayA = new ComparableArray(sortedArrayB);
            var visitableArrayB = new ComparableArray(sortedArrayA);

            for (int i = 0; i < mergedArray.Length; i++)
                mergedArray[i] = visitableArrayB.GetNextSmallerElement(visitableArrayA);

            return mergedArray;
        }
    }
}
