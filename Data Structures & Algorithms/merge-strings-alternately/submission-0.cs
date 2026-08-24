public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var result = string.Empty;
        int i=0, j=0;
        int l1 = word1.Length; 
        int l2 = word2.Length;

        while(i<l1 || j<l2)
        {
            if(i < l1)
            {
                result += word1[i];
                i++;
            }
            if(j < l2)
            {
                result += word2[j];
                j++;
            }
        }
        return result;

    }
}