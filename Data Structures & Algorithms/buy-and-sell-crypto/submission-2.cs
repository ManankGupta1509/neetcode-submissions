public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        int current = 0;
        for(int i=1;i<prices.Length;i++)
        {
            if(prices[current] < prices[i])
            {
                max = Math.Max(prices[i] - prices[current],max);
            }
            else if(prices[i] < prices[current])
            {
                current = i;
            }
        }
        return max;
    }
}
