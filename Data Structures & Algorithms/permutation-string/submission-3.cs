public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        Dictionary<char,int> map = new Dictionary<char,int>();
        int diff = 0;
        bool isPerm = false;
        
        if(s2.Length < s1.Length)
            return false;
        
        foreach(char c in s1)
        {
            if(map.ContainsKey(c))
                map[c]++;
            else
                map[c]=1;
        }

        int j=0;
        for(int i=0; i<s2.Length; i++)
        {
            j=i;
            var window = new Dictionary<char,int>();
            while(map.ContainsKey(s2[j]) && diff+1<=s1.Length)
            {
                diff++;
                if(window.TryGetValue(s2[j], out var v))
                {
                    window[s2[j]]++;
                }
                else
                {
                    window.Add(s2[j],1);
                }
                if(window[s2[j]] > map[s2[j]])
                    break;
                j++;
                if(diff == s1.Length)
                    return true;
                if(j>=s2.Length)
                    return false;
            }
            diff=0;
        }
        return false;
    }
}
