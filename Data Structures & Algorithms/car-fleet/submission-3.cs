public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        Stack<double> carFleet = new Stack<double>();
        int n = speed.Length;
        int[][] pair = new int[n][];
        for(int i=0; i<n; i++)
        {
            pair[i] = new int[]{position[i], speed[i]};
        }
        Array.Sort(pair, (a, b) => b[0].CompareTo(a[0]));
        foreach(var p in pair)
        {
            double x = (double)(target-p[0])/p[1];
            carFleet.Push(x);
            if(carFleet.Count >= 2 && carFleet.ElementAt(1) >= carFleet.Peek())
            {
                carFleet.Pop();
            }
                
        }
        return carFleet.Count;
    }
}
