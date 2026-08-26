public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int l=0; int r=people.Length-1;
        int count=0;
        while(l<=r)
        {
            if(people[r] == limit)
            {
                count++;
                r--;
                continue;
            }

            if(people[l] + people[r] <= limit)
            {
                count++;
                l++;
                r--;
            }
            else
            {
                count++;
                r--;
            }
        }
        return count;
    }
}