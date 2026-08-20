public class Solution {
    public int MajorityElement(int[] nums) {
        var map = new Dictionary<int,int>();
        int max = 0;
        int result = nums[0];
        foreach(int num in nums)
        {
            if(map.TryGetValue(num, out var value))
            {
                map[num] = value+1;
                if(map[num] > max)
                {
                max = map[num];
                result = num;
                }
            }
            else
            {
                map.Add(num,1);
                if(map[num] > max)
                {
                max = map[num];
                result = num;
                }
            }
        }
        return result;

    }
}