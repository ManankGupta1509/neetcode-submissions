public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k %= n;
        int count = 0;

        for(int i=0; count<n; i++)
        {
            int current = i;
            int prev = nums[i];

            do{
                int j = (current + k) % n;
                int temp = nums[j];
                nums[j] =prev;
                prev = temp;
                current = j;
                count++;
            }while(i != current);
        }

    }
}