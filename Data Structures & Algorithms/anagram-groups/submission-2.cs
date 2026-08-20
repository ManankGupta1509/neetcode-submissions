public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        List<List<string>> anagrams = new List<List<string>>();
        var emptyList = strs.Where(x => x==string.Empty).ToList();
        if(emptyList.Count > 0)
            anagrams.Add(emptyList);
        for(int i=0; i<strs.Length; i++)
        {
            if(strs[i] != string.Empty)
            {                
                var group = new List<string>();
                group.Add(strs[i]);
                for(int j=i+1; j<strs.Length; j++)
                {
                    if(IsAnagram(strs[i] , strs[j]))
                    {
                        group.Add(strs[j]);
                        strs[j] = string.Empty;
                    }
                }
                anagrams.Add(group);
            }
        }
        return anagrams;
    }

    public bool IsAnagram(string s, string t)
    {
        int[] charArray = new int[26];

        if(s.Length != t.Length)
            return false;

        for(int i=0 ; i< s.Length; i++)
        {
            charArray[s[i] - 'a']++;
            charArray[t[i] - 'a']--;
        }
        for(int i=0; i<s.Length; i++)
        {
            if(charArray[s[i] - 'a'] != 0)
                return false;
        }
        return true;
    }
}
