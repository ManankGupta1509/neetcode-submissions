public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length != t.Length)
            return false;

        char[] s1 = s.ToCharArray();
        char[] s2 = t.ToCharArray();
        Dictionary<char,int> frequency = new Dictionary<char,int>();
        for(int i=0 ; i < s.Length; i++)
        {
            if(!t.Contains(s1[i]))
            {
                return false;
            }
            if(frequency.TryGetValue(s1[i],out var value))
            {
                frequency[s1[i]] =value+1;
            }
            else
            {
                frequency.Add(s1[i],1);
            }

            if(frequency.TryGetValue(s2[i],out var value1))
            {
                frequency[s2[i]]=value1+1;
            }
            else
            {
                frequency.Add(s2[i],1);
            }
        }

        for(int i=0 ; i < s.Length; i++)
        {
            if(Convert.ToDecimal(frequency[s1[i]])%2 != 0m)
                return false;
        }

        return true;

    }
}
