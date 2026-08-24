public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var set = new HashSet<int>(nums);
        int j=0;
        foreach(int i in set)
        {
            nums[j++] = i;
        }
        set = null;
        return j;
    }
}