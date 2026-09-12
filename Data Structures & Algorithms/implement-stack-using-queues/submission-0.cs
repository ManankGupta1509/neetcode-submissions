public class MyStack {

    private Queue<int> set;
    public MyStack() {
        set = new Queue<int>();
    }
    
    public void Push(int x) {
        var temp = new Queue<int>();
        while(set.Count > 0)
        {
            temp.Enqueue(set.Dequeue());
        }
        set.Enqueue(x);
        while(temp.Count>0)
        {
            set.Enqueue(temp.Dequeue());
        }
    }
    
    public int Pop() {
        return set.Dequeue();
    }
    
    public int Top() {
        return set.Peek();
    }
    
    public bool Empty() {
        return set.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */