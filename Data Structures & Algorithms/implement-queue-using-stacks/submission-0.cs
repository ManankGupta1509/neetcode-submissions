public class MyQueue {
    private Stack<int> set;
    public MyQueue() {
        set = new Stack<int>();
    }
    
    public void Push(int x) {
        var temp = new Stack<int>();
        while(set.Count>0)
        {
            temp.Push(set.Pop());
        }
        set.Push(x);
        while(temp.Count>0)
        {
            set.Push(temp.Pop());
        }
    }
    
    public int Pop() {
        return set.Pop();
    }
    
    public int Peek() {
     return set.Peek();   
    }
    
    public bool Empty() {
        return set.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */