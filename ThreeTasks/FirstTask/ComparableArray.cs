using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTask
{
    public class ComparableArray
    {
        private readonly int[] _sortedArray;
        private int _lastIndexCheckOnArray;

        public ComparableArray(int[] sortedArray)
        {
            _lastIndexCheckOnArray = 0;
            _sortedArray = sortedArray;
        }

        public int GetNextSmallerElement(ComparableArray arrayToCompare)
        {
            if (CanPickNext)
            {
                if (arrayToCompare.CanPickNext)
                {
                    if (Current < arrayToCompare.Current)
                        return GetAndMove();
                    else
                        return arrayToCompare.GetAndMove();
                }
                return GetAndMove();
            }

            return arrayToCompare.GetAndMove();
        }

        private int Current
        {
            get { return _sortedArray[_lastIndexCheckOnArray]; }
        }

        private bool CanPickNext
        {
            get { return _lastIndexCheckOnArray < _sortedArray.Length; }
        }

        private int GetAndMove()
        {
            _lastIndexCheckOnArray++;
            return _sortedArray[_lastIndexCheckOnArray - 1];
        }
    }
}
