public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string result = string.Empty;
        bool present = true;
        for (int i=0; i<strs[0].Length; i++)
        {
            foreach(string str in strs)
            {
                if((i == str.Length) || (str[i] != strs[0][i]))
                {
                    present = false;
                    break;
                }
            }

            if(present)
            {
                result += strs[0][i];
            }
            else
            {
                break;
            }
        }
        return result;
    }
}