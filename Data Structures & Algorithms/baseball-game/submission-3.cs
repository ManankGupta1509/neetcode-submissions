public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> scores = new Stack<int>();
        int a=0;
        foreach(string s in operations)
        {
            if(s.Equals("C"))
            {
                scores.Pop();
            }
            else if(s.Equals("+"))
            {
                a=scores.Pop();
                var sum = a+scores.Peek();
                scores.Push(a);
                scores.Push(sum);
            }
            else if(s.Equals("D"))
            {
                scores.Push(2*scores.Peek());
            }
            else
            {
                scores.Push(Convert.ToInt32(s));
            }
        }
        var result =0;
        while (scores.Count > 0) {
            result += scores.Pop();
        }
        return result;
    }
}