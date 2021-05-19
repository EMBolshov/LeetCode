using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Recursion_II._1_DivideAndConquer
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-ii/470/divide-and-conquer/2944/
    /// </summary>
    public static class SortAnArray
    {
        public static int[] SortArray(int[] nums)
        {
            return MergeSort(nums);
        }

        private static int[] MergeSort(int[] nums)
        {
            return Divide(nums);

            int[] Divide(int[] arr)
            {
                if (arr.Length == 1)
                    return arr;

                var half = arr.Length / 2;
                var left = arr[..half];
                var right = arr[half ..];

                var res = Merge(Divide(left), Divide(right));

                return res;
            }
            

            int[] Merge(int[] left, int[] right)
            {
                var length = left.Length + right.Length;
                var res = new int[length];

                int i = 0;
                int j = 0;
                
                for (int k = 0; k < length; k++)
                {
                    if (i == left.Length)
                    {
                        res[k] = right[j];
                        j++;
                        continue;
                    }

                    if (j == right.Length)
                    {
                        res[k] = left[i];
                        i++;
                        continue;
                    }
                    
                    if (left[i] < right[j])
                    {
                        res[k] = left[i];
                        i++;
                    }
                    else 
                    {
                        res[k] = right[j];
                        j++;
                    }
                }

                return res;
            }
        }

        private static int[] MergeSortIteratively(int[] nums)
        {
            var splitted = new List<List<int>>();
            
            nums.ToList().ForEach(i => splitted.Add(new List<int>{i}));

            while (splitted.Count != 1)
            {
                var half = splitted.Count / 2;
                var firstHalf = splitted.Take(half).ToList();
                var secondHalf = splitted.Skip(half).Take(nums.Length - half).ToList();
                
                var isOdd = splitted.Count % 2 != 0;
                
                splitted.Clear();

                var minLength = firstHalf.Count < secondHalf.Count ? firstHalf.Count : secondHalf.Count;

                for (int i = 0; i < minLength; i++)
                {
                    splitted.Add(Merge(firstHalf[i], secondHalf[i]));
                }

                if (isOdd && secondHalf.Any())
                {
                    splitted.Add(secondHalf.Last());
                }
            }

            var result = splitted[0].ToArray();
                        
            return result;


            List<int> Merge(IList<int> first, IList<int> second)
            {
                var res = new List<int>();

                while (first.Any() || second.Any())
                {
                    if (!first.Any())
                    {
                        res.AddRange(second);
                        break;
                    }

                    if (!second.Any())
                    {
                        res.AddRange(first);
                        break;
                    }

                    if (first[0] < second[0])
                    {
                        res.Add(first[0]);
                        first.RemoveAt(0);
                    }
                    else
                    {
                        res.Add(second[0]);
                        second.RemoveAt(0);
                    }
                }

                return res;
            }
        }
    }
}