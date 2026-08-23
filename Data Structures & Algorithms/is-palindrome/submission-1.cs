public class Solution {
    public bool IsPalindrome(string s) {
        string temp = string.Empty;
        foreach(char c in s)
        {
            if((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')  || (c >= '0' && c <= '9'))
            temp += c;
        }
        s = temp.ToLower();
        temp = string.Empty;
        int i=0; 
        int j = s.Length-1;
        while(i<j)
        {
            if(s[i] != s[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
