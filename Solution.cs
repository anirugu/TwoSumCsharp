public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            var remain = target - nums[i];
            var index = FindIndex(remain, i + 1, nums);
            if (index != -1)
                return new int[] { i, index };
        }
        return new int[] { };
    }

    private int FindIndex(int item, int startIndex, int[] items)
    {
        for (int i = startIndex; i < items.Length; i++)
        {
            if (items[i] == item)
                return i;
        }
        return -1;
    }
}