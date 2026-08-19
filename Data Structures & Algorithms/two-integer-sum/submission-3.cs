public class Solution {
    public int[] TwoSum(int[] nums, int target) {
     Dictionary<int,int> map = new Dictionary<int,int>();
     int[] result = new int[2];
     for(int i=0; i<nums.Length; i++)
     {
        if(map.ContainsKey(nums[i]))
            map[nums[i]] = i;
        else
            map.Add(nums[i],i);
     }

     for(int i=0; i<nums.Length;i++)
     {
        if(map.TryGetValue(target-nums[i], out var value))
        {
            if(i!=value)
            {
            result[0] = i;
            result[1] = value;
            break;
            }
        }
     }

     return result;
    }
}
