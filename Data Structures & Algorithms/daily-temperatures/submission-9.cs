public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] result = new int[temperatures.Length];
        for(int i=n-2; i>=0; i--)
        {
            int j = i+1;
            while(j<n && temperatures[j] <= temperatures[i])
            {
                if(result[j] == 0)
                {
                    j=n;
                    break;
                }
                j+=result[j];
            }

            if(j<n)
                result[i] = j-i;
        }
        return result;
    }
}
