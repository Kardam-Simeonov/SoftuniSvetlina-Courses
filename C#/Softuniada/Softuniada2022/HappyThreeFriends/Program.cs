using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyThreeFriends
{
    internal class Program
    {
        public static List<int> subArray = new List<int>();
        public static List<int> indicesToRemove = new List<int>();

        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            List<int[]> batches = new List<int[]>();

            for (int i = 0; i < orders; i++)
                batches.Add(Console.ReadLine().Split().Select(int.Parse).ToArray());

            foreach (var batch in batches)
            {
                if (CalculateSplits(batch))
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
        }

        static bool CalculateSplits(int[] batch)
        {
            List<int> arr = batch.ToList();
            arr.Sort();
            arr.Reverse();

            int sum = arr.Sum();
            int foundSubArrays = 0;

            if (sum % 3 == 0)
            {
                int sumGoal = sum / 3;

                while (foundSubArrays != 3)
                {
                    int k;
                    for (k = 0; k < arr.Count; k++)
                    {
                        for (int i = k; i < arr.Count(); i++)
                        {
                            if (subArray.Sum() + arr[i] <= sumGoal)
                            {
                                subArray.Add(arr[i]);
                                indicesToRemove.Add(i);
                            }
                        }

                        if (subArray.Sum() == sumGoal)
                        {
                            foundSubArrays++;
                            for (int i = 0; i < indicesToRemove.Count(); i++)
                            {
                                arr.RemoveAt(indicesToRemove[i] - i);
                            }
                            subArray.Clear();
                            indicesToRemove.Clear();
                            break;
                        }

                        subArray.Clear();
                        indicesToRemove.Clear();
                        
                    }

                    if (k == arr.Count && arr.Count != 0)
                        return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
