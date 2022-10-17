using System.Linq;
using System.Collections.Generic;

namespace TwoSumCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            TwoSum(new int[] { 3, 2, 4 }, 6);
        }

        public static int[] TwoSum(IEnumerable<int> nums, int target)
        {
            int index = 0;
            int count = nums.Count();

            foreach (int x in nums)
            {
                int remain = target - x;
                int secondIndex = FindIndex(nums.Skip(index + 1), remain);
                if (secondIndex != -1)
                    return new int[] { index, secondIndex + index + 1 };
                index++;
            }
            return new int[] { };
        }

        private static int FindIndex(IEnumerable<int> nums, int target)
        {
            int index = -1;
            int count = nums.Count();
            foreach (var num in nums)
            {
                index++;
                if (num == target)
                    return index;
            }
            return -1;
        }
    }


}