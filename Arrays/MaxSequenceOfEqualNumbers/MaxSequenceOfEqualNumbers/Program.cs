using System;
using System.Linq;

namespace MaxSequenceOfEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int count= 0;
            int highest = int.MinValue;
            int highestElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    count++;
                    highestElement = arr[i];
                }

                else if (i == arr.Length - 1)  
                {
                    if (arr[i] == arr[i - 1])
                    {
                        count++;

                        if (count > highest)
                        {
                            highest = count;
                            highestElement = arr[i - 1];
                            count = 1;

                        }
                    }

                    else
                    {
                        if (count > highest)
                        {
                            highest = count;
                            highestElement = arr[i - 1];
                            count = 1;

                        }
                    }
                }

                else
                {
                    if (arr[i] == arr[i - 1])
                        count++;
                    else
                    {
                        if (count > highest)
                        {
                            highest = count;
                            highestElement = arr[i - 1];
                            count = 1;

                        }
                        else
                        {
                            count = 1;
                        }
                    }
                }
            }
            
            int[] highestSequence = new int[highest];

            for (int i = 0; i < highestSequence.Length; i++)
                highestSequence[i] = highestElement;

            Console.WriteLine(String.Join(" ", highestSequence));
            //Console.WriteLine(highest);
            //Console.WriteLine(highestElement);
        }
    }
}
