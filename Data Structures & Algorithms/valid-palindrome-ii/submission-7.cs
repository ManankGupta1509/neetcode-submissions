public class Solution {
    public bool ValidPalindrome(string s) {
        int l =0; 
        int r= s.Length-1;
        while(l<r)
        {
            if(s[l] != s[r])
            {
                return (IsPallindrome(s, l+1, r) || IsPallindrome(s, l, r-1));
            }
            l++;
            r--;
        }
        
        return true;

    }

    public bool IsPallindrome(string s ,int  l , int r)
    {
        while(l<r)
        {
            if(s[l]!=s[r])
                return false;
            l++;
            r--;
        }
        return true;
    }
}