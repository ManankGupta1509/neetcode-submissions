public class Solution {
    public bool ValidPalindrome(string s) {
        int l =0; 
        int r= s.Length-1;
        while(l<r)
        {
            if(s[l] != s[r])
            {
                var skipL = s.Substring(l+1,r-l);
                var skipR = s.Substring(l, r-l);
                return (IsPallindrome(skipL) || IsPallindrome(skipR));
            }
            l++;
            r--;
        }
        
        return true;

    }

    public bool IsPallindrome(string s)
    {
        int l =0 ; 
        int r= s.Length-1;
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