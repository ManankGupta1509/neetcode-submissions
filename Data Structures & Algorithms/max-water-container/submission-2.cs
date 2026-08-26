public class Solution {
    public int MaxArea(int[] heights) {
        int l =0 ; int r= heights.Length-1;
        int max=0;
        while (l<r)
        {
            int current =  Area(Math.Min(heights[l],heights[r]),r-l);
            max= Math.Max(max ,current);
            if(heights[l]<=heights[r])
            {
                l++;
            }
            else
            {
                r--;
            }
        }
        return max;
    }

    public int Area(int l , int w)
    {
        return l*w;
    }
}
