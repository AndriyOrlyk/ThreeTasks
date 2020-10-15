using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondTask
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] arr = new int[100];

            AddingArray(arr);
            int arr_size = arr.Length;
            arr[0] = 10;
            arr[20] = 10;
            arr[2] = 10;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.Write("\n");
            RepeatElement element = new RepeatElement(arr, arr_size);
            element.Repeat();

        }
       
        private static void AddingArray(int[] arr)
        {
            for (int i = 0; i < 100; i++)
            {
                arr[i] = i;
            }
        }
    }
}
