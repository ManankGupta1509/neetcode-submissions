public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max =0;
        int count=0;
        HashSet<char> set = new HashSet<char>();
        
        for(int i=0; i<s.Length; i++)
        {
            while(set.Contains(s[i]))
            {
                set.Remove(s[count]);
                count++;
            }
            set.Add(s[i]);
            max = Math.Max(max,i-count+1);
        }
        return max;
    }
}
