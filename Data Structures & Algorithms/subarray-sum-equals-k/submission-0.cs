public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int result = 0;
        int sum =0;
        for(int i=0 ; i<nums.Length-1; i++)
        {
            sum += nums[i];
            if(sum == k)
                result++;
            for(int j=i+1; j< nums.Length; j++)
            {
                sum += nums[j]; 
                if(sum == k)
                    result++;               
            }
            sum = 0;
        }

        if(nums[nums.Length -1] == k)
            result++;

        return result;
    }
}