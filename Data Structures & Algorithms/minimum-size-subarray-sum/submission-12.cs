public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int min = int.MaxValue;
        int sum = 0;
        int i = 0;

        for (int j = 0; j < nums.Length; j++) {
            sum += nums[j];

            while (sum >= target) {
                min = Math.Min(min, j - i + 1);
                sum -= nums[i];
                i++;
            }
        }

        return min == int.MaxValue ? 0 : min;
    }
}