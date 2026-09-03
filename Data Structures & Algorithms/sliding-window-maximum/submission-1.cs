public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        int[] leftmax = new int[n];
        int[] rightmax = new int[n];

        leftmax[0] = nums[0];
        rightmax[n-1] = nums[n-1];
        for(int i=1; i<n; i++)
        {
            if(i%k ==0)
                leftmax[i] = nums[i];
            else
                leftmax[i] = Math.Max(leftmax[i-1] , nums[i]);

            if((n-i-1)%k ==0)
                rightmax[n-i-1] = nums[n-i-1];
            else
                rightmax[n-i-1] = Math.Max(rightmax[n-i] , nums[n-i-1]);
        }

        var result = new int[n-k+1];
        for(int i=0;i<=n-k;i++)
        {
            result[i] = Math.Max(leftmax[i+k-1],rightmax[i]);
        }
        return result;
    }
}
