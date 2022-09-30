using System.Linq;
using System.Collections.Generic;

namespace TwoSumCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            //TwoSum(new int[] { 3, 2, 4 }, 6);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Array.FindIndex(nums.Skip(i + 1).ToArray(), x => x == target - nums[i]);
                if (index != -1)
                {
                    result = new int[] { i, index + (i+1) };
                    break;
                }
            }
            return result;
        }
    }


}