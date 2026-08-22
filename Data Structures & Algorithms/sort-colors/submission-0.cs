public class Solution {
    public void SortColors(int[] nums) {
        if(nums == null || nums.Length <= 1)
            return;

        int[] freq = new int[3];
        foreach(int i in nums)
        {
            freq[i] += 1;
        }
        
        int j=0;
        for(int i=0; i<freq.Length; i++)
        {
            while(freq[i] > 0)
            {
                nums[j++] = i;
                freq[i]--;
            }
        }
    }
}