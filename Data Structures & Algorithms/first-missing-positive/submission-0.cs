public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int max =0 ;
        var set = new HashSet<int>();
        foreach(int i in nums)
        {
            if(i > 0)
            {
                set.Add(i);
                max = Math.Max(max,i);
            }
        }

        int result = -1;
        for(int i=1; i<=max; i++)
        {
            if(set.Add(i))
            {
                result = i;
                break;
            }
        }
        if(result > 0)
            return result;
        else
            return max+1;
    }
}