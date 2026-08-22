public class Solution {

    public string Encode(IList<string> strs) {
        string result = string.Empty;
        foreach(var str in strs)
        {
            result += $"{str.Length}#{str}";
        }
        return result;
    }

    public List<string> Decode(string s) {
        int i=0;
        List<string> str = new List<string>();
        while(i < s.Length)
        {
            int j = i;
            while(s[j] != '#')
            {
                j++;
            }
            int length = Convert.ToInt32(s.Substring(i,j-i));
            i = j+1;
            str.Add(s.Substring(i,length));
            i += length;
        }
        return str;
   }
}
