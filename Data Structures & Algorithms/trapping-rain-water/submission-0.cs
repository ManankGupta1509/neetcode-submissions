public class Solution {
    public int Trap(int[] height) {
        int leftmax =0;
        int rightmax=0;
        int l=0;
        int r=height.Length-1;
        int water=0;
        while(l<r)
        {
            if(height[l]<=height[r])
            {
                if(height[l]>=leftmax)
                    leftmax = height[l];
                else
                {
                    water += leftmax- height[l];
                }
                l++;
            }
            else
            {
                 if(height[r]>=rightmax)
                    rightmax = height[r];
                else
                {
                    water += rightmax - height[r];
                }
                r--;
            }
        }
        return water;
    }
}
