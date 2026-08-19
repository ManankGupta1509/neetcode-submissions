public class Solution {
    public bool hasDuplicate(int[] nums) {
        int count = nums.Length;
        Dictionary<int,int> frequency = new Dictionary<int,int>();
        for(int i=0; i<count; i++)
        {
            if(frequency.TryGetValue(nums[i],out var value))
                return true;
            else
                frequency.Add(nums[i], 1);
        }
        return false;
    }
}