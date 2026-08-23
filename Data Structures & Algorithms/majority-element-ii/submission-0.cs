public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int check = nums.Length/3;
        var map = new Dictionary<int,int>();
        var result = new List<int>();
        foreach(int i in nums)
        {
            if(map.TryGetValue(i , out var count))
            {
                map[i] = count+1;
            }
            else
            {
                map.Add(i,1);
            }
        }

        foreach(var entry in map)
        {
            if(entry.Value > check)
                result.Add(entry.Key);
        }
        return result;
    }
}