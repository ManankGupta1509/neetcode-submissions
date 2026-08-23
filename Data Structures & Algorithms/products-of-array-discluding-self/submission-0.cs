public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int total = 1;
        int zeroCount = 0;
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] != 0)
                total *= nums[i];
            else
                zeroCount++;
        }
        int[] result = new int[nums.Length];
        for(int i=0; i<nums.Length; i++)
        {
            if(zeroCount > 0)
            {
                if(zeroCount == 1 && nums[i] == 0)
                {
                    result[i] = total;
                }
                else
                {
                    result[i] = 0;
                }
            }
            else
            {
                result[i] = total/nums[i];
            }
        }
        return result;
    }
}
