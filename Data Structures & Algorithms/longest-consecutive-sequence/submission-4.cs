public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums == null || nums.Length == 0)
            return 0;
        
        if(nums.Length < 2 && nums[0] > 0)
            return 0;

        var set = new HashSet<int>();
        Array.Sort(nums);
        foreach(int i in nums)
        {
            set.Add(i);
        }
        int count =1;
        int max=0;
        var list = set.ToList();
        for(int i=0 ; i < list.Count -1; i++)
        {
            var difference = list[i+1]- list[i];
            if(difference == 1)
            {
                count++;
            }
            else
            {
                max = Math.Max(max,count);
                count = 1;
            } 
        }
        if(count > max)
            max = count;
        return max;
    }
}
