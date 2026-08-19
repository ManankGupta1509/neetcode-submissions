public class Solution {
    public bool hasDuplicate(int[] nums) {
        int count = nums.Length;
        HashSet<int> distinct = new HashSet<int>();
        for(int i=0; i<count; i++)
        {
            if(!distinct.Add(nums[i]))
                return true;
        }
        return false;
    }
}