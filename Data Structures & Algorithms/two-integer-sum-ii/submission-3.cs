public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var map = new Dictionary<int,int>();
        for(int i=0; i<numbers.Length; i++)
        {
            if(map.TryGetValue(target-numbers[i] , out var value))
            {
                return new int[]{value+1 , i+1};
            }
            else if(!map.TryGetValue(numbers[i], out var v))
            {
                map.Add(numbers[i] , i);
            }
        }
        return new int[0];
    }
}
