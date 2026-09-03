public class Solution {
    public string MinWindow(string s, string t) {
        string result = "";
        if(t.Length > s.Length)
            return "";
        var map = new Dictionary<char,int>();
        var freq = new Dictionary<char,int>();
        foreach(char c in t)
        {
           if(map.ContainsKey(c))
            map[c]++;
           else 
            map[c] = 1;
        }
        int current =0, need = map.Count;
        int resLen = int.MaxValue , l=0;
        int startIdx = 0;
        
        for(int r=0; r<s.Length;r++)
        {
            if(freq.ContainsKey(s[r]))
                freq[s[r]]++;
            else
                freq[s[r]] = 1;

            if(map.ContainsKey(s[r]) && map[s[r]] == freq[s[r]])
                current++;
            
            while(current == need)
            {
                if(resLen > (r-l+1))
                {
                    resLen = r-l+1;
                    startIdx = l;
                }

                freq[s[l]]--;
                if(map.ContainsKey(s[l]) && map[s[l]] > freq[s[l]])
                {
                    current--;
                }
                l++;
            }
        }
        result = (resLen == int.MaxValue) ? "" : s.Substring(startIdx,resLen);
        return result;
    }
}
