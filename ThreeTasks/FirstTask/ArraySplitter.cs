namespace FirstTask
{
    public class ArraySplitter
    {
        private readonly int[] _arrayToSort;
        private readonly int[] _firstPart;
        private readonly int[] _secondPart;

        public ArraySplitter(int[] arrayToSort)
        {
            _arrayToSort = arrayToSort;
            _firstPart = new int[_arrayToSort.Length / 2];
            _secondPart = new int[_arrayToSort.Length - _firstPart.Length];
        }

        public int[] GetFirstPart()
        {
            for (int i = 0; i < (_arrayToSort.Length / 2); i++)
                _firstPart[i] = _arrayToSort[i];

            return _firstPart;
        }

        public int[] GetSecondPart()
        {
            for (int i = 0; i < _arrayToSort.Length - (_arrayToSort.Length / 2); i++)
                _secondPart[i] = _arrayToSort[_firstPart.Length + i];

            return _secondPart;
        }
    }
}
