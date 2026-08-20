public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string result = string.Empty;
        int largestLength = 0;
        string largestString = string.Empty;
        bool present = true;
        foreach(string str in strs)
        {
            if(str.Length > largestLength)
            {
                largestString = str;
                largestLength = str.Length;
            }
        }

        for (int i=0; i<largestLength; i++)
        {
            foreach(string str in strs)
            {
                if(i >= str.Length)
                {
                    present = false;
                    break;
                }
                if(str[i] != largestString[i])
                {
                    present = false;
                    break;
                }
            }

            if(present)
            {
                result += largestString[i];
            }
            else
            {
                break;
            }
        }
        return result;
    }
}