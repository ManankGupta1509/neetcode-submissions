public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        var map = new Dictionary<int,List<int>>();
        var result = new List<int>();
        foreach(int i in arr)
        {
            var diff = Math.Abs(x-i);
            if(map.TryGetValue(diff, out List<int> v))
            {
                map[diff].Add(i); 
            }
            else
            {
                map[diff] = new List<int>{ i };
            }
        }

        foreach(var key in map.Keys.OrderBy(p => p))
        {
            if(map[key].Count >= k)
            {
                result.AddRange(map[key].Take(k));
                break;
            }
            else
            {
                result.AddRange(map[key]);
                k = k-map[key].Count;   
            }
        }
        return result.OrderBy(y => y).ToList();
    }
}