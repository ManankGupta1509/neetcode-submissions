public class MinStack {
    Stack<int> set;
    int min = int.MaxValue;
    public MinStack() {
        set = new Stack<int>();
    }
    
    public void Push(int val) {
        if(val<min)
            min = val;
        set.Push(val);
    }
    
    public void Pop() {
        if(set.Count>0)
        {
           var curr = set.Pop();
           if(curr == min)
           {
            min = int.MaxValue;
            foreach(int i in set)
            {
                if(i<min)
                min = i;
            }
           }
        }
    }
    
    public int Top() {
        return set.Peek();
    }
    
    public int GetMin() {
        return min;
    }
}
