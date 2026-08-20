public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var temp = new List<int>();
        var length = nums.Length;
        int startIndex = 0;
        int lastIndex = 0;
        int count=0;
        Array.Sort(nums);
        for(int i=0; i<length; i++)
        {
            if(nums[i] == val)
            {
                count++;
                if(count>1)
                {
                    lastIndex = i;
                }
                else
                {
                    startIndex = lastIndex = i;
                }
            }
        }

        if(count==0)
            return length;

        for(int i=lastIndex+1; i<length; i++)
        {
            nums[startIndex] = nums[i];
            startIndex++;
        }
        return length-count;
    }
}