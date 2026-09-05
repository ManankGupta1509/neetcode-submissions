public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> scores = new Stack<int>();
        int a=0,b=0;
        foreach(string s in operations)
        {
            if(s.Equals("C"))
            {
                scores.Pop();
            }
            else if(s.Equals("+"))
            {
                a=scores.Pop();
                b=scores.Peek();
                scores.Push(a);
                scores.Push(a+b);
            }
            else if(s.Equals("D"))
            {
                a=scores.Pop();
                scores.Push(a);
                scores.Push(2*a);
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