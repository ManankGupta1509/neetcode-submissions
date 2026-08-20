public class MyHashMap {

    private int[] _set;
    public MyHashMap() {
        _set = new int[1000001];
        Array.Fill(_set,-1);
    }
    
    public void Put(int key, int value) {
        _set[key] = value;
    }
    
    public int? Get(int key) {
        return _set[key];
    }
    
    public void Remove(int key) {
        _set[key] = -1;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */