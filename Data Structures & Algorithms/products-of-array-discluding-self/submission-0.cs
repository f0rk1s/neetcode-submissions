public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] fromLeft = new int[nums.Length];
        int[] fromRight = new int[nums.Length];

        fromLeft[0] = nums[0];
        fromRight[nums.Length - 1] = nums[nums.Length - 1];
        for (int i = 1; i < nums.Length; i++)
        {
            fromLeft[i] = fromLeft[i - 1] * nums[i];
        }
        
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            fromRight[i] = fromRight[i + 1] * nums[i];
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            
            int left = i > 0 ? fromLeft[i - 1] : 1;
            int right = i < (nums.Length - 1) ? fromRight[i + 1] : 1;

            nums[i] = left * right;
        }

        return nums;
    }
}