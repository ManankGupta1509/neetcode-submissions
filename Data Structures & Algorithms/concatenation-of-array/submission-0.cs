public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int length = nums.Length;
        int[] ans = new int[2*length];
        for(int i=0; i<length; i++)
        {
            ans[i] = ans[i+length] = nums[i];
        }
        return ans;
    }
}