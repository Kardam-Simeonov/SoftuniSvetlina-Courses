using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 2, 1 };

            InsertionSort(array);
        }

        static void InsertionSort(int[] array)
        {
            int wholePos;
            int valueToInsert;

            for (int i = 1; i < array.Length; i++)
            {
                valueToInsert = array[i];
                wholePos = i;

                while (wholePos > 0 && array[wholePos - 1] > valueToInsert)
                {
                    array[wholePos] = array[wholePos - 1];
                    wholePos--;
                }
                array[wholePos] = valueToInsert;
            }

            Console.WriteLine(array);
        }
    }
}
