using System;

namespace SecondTask
{
    public class RepeatElement
    {
        private int[] arr;
        private int size;

        public RepeatElement(int[] _arr, int _size) 
        {
            arr = _arr;
            size = _size;
        }
       
        public void Repeat()
        {
            Console.Write("The repeating elements are : ");

            int flag = 0;

            for (int i = 0; i < size; i++)
            {

                if (arr[arr[i] % size] >= size)
                {
                    if (arr[arr[i] % size] < 2 * size)
                    {
                        Console.Write(arr[i] % size + " ");
                        flag = 1;
                    }
                } 
                arr[arr[i] % size] += size;
            }

            if (!(flag > 0))
                Console.Write("-1");
        }
    }
}
