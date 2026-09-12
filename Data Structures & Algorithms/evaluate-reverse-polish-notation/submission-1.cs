public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> numbs = new Stack<int>();
        int val1=0, val2=0;
        foreach(string token in tokens)
        {
            switch(token)
            {
                case "+" : 
                val2 = numbs.Pop();
                val1 = numbs.Pop();
                numbs.Push(val1 + val2); 
                break;
                case "*" :  
                val2 = numbs.Pop();
                val1 = numbs.Pop();
                numbs.Push(val1 * val2); 
                break;
                case "-" :  
                val2 = numbs.Pop();
                val1 = numbs.Pop();
                numbs.Push(val1 - val2); 
                break;
                case "/" :  
                val2 = numbs.Pop();
                val1 = numbs.Pop();
                numbs.Push(val1 / val2); 
                break;
                default : numbs.Push(Convert.ToInt32(token)); break;
            }
        }
        return numbs.Pop();
    }
}
