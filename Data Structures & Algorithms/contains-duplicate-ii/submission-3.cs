public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var map = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(map.TryGetValue(nums[i],out var value))
            {
                if(Math.Abs(i-value) <= k)
                    return true;
            }
            map[nums[i]] = i;
        }
        return false;
    }
}