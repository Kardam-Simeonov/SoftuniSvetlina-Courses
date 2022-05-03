using System;

namespace InversionCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class MergeSort
    {
        private static int[] auxArr;
        public static int[] Sort(int[] arr)
        {
            auxArr = new int[arr.Length];
            Sort(arr, 0, arr.Length - 1);

            return arr;
        }
        
        private static void Sort(int[] arr, int leftIndex, int rightIndex)
        {
            // If there is only one element in the subarray,
            // it is already sorted
            if (leftIndex >= rightIndex)
                return;

            // If not, split it into two subarrays,
            // sort them recursively 
            int midIndex = (leftIndex + rightIndex) / 2;
            Sort(arr, leftIndex, midIndex);
            Sort(arr, midIndex + 1, rightIndex);

            // Merge them as a post action
            Merge(arr, leftIndex, midIndex, rightIndex);
        }

        private static void Merge(int[] arr, int leftIndex, int midIndex, int rightIndex)
        {
            // If the largest element in the left is smaller than the smallest in the right, 
            // the two subarrays are already merged
            if (arr[midIndex]< arr[midIndex + 1])
                return;
            

            // If no, transfer all elements to the auxillary array,
            // then merge them back to the main array

            for (int index = leftIndex; index < rightIndex + 1; index++)
            {
                auxArr[index] = arr[index];
            }

            // NOTE: The following pointers are incremented each time they get used
            // i - left pointer for the auxillary array
            // j - right pointer for the auxillary array
            int i = leftIndex;
            int j = midIndex + 1;

            for (int currIndex = leftIndex; currIndex <= rightIndex; currIndex++)
            {
                // In case the left partition has been exhausted,
                // copy the element from the right array
                if (i > midIndex)
                    arr[currIndex] = auxArr[j++];

                // In case the right partition has been exhausted,
                // copy the element from the left array
                else if (j > rightIndex)
                    arr[currIndex] = auxArr[i++];

                // If the left element is less than the right,
                // copy the element from the left array;
                else if (auxArr[i] < auxArr[j])
                    arr[currIndex] = auxArr[i++];

                // Else the element from the right array is smaller
                else
                    arr[currIndex] = auxArr[j++];
            }
        }
    }
}
