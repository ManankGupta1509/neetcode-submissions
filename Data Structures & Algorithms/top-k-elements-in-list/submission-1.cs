public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int,int>();
        List<int> result = new List<int>();
        foreach(int i in nums)
        {
            if(map.TryGetValue(i, out var value))
            {
                    map[i] = value+1;
            }
            else
            {
                map.Add(i,1);
            }
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach(var entry in map)
        {
            var freq = entry.Value;
            if(buckets[freq] == null)
                buckets[freq] = new List<int>();
            buckets[freq].Add(entry.Key);
        }

        for(int i = buckets.Length-1 ; i>=0 && result.Count < k ; i--)
        {
            if(buckets[i] != null)
                result.AddRange(buckets[i]);
        }

        return result.ToArray();
    }
}
