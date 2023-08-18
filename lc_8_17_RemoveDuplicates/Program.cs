public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();
        int position = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (result.TryAdd(nums[i], nums[i]))
            {
                nums[position] = nums[i];
                position++;
            }
        }

        return result.Count;
    }
}