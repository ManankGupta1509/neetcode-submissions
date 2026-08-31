public class Solution {
    public int CharacterReplacement(string s, int k) {
     Dictionary<char,int> map = new Dictionary<char,int>();
     int result =0;
     int maxf =0;
     int l=0;

     for(int r=0; r<s.Length;r++)
     {
        if(map.ContainsKey(s[r]))
        {
            map[s[r]]++;
        }
        else
        {
            map[s[r]] = 1;
        }
        maxf = Math.Max(maxf , map[s[r]]);
        while((r-l+1)-maxf > k )
        {
            map[s[l]]--;
            l++;
        }
        result = Math.Max(result , (r-l+1));
     }
        return result;
    }
}
