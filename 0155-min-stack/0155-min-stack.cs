public class MinStack {
    private List<int> _list;
    public MinStack() {
        _list= new List<int>();
    }
    
    public void Push(int val) {
        _list.Add(val);
    }
    
    public void Pop() {
        _list.RemoveAt(_list.Count()-1);
    }
    
    public int Top() {
        return _list[_list.Count()-1];
    }
    
    public int GetMin() {
        int min =_list[0];
        for(int i=0 ; i< _list.Count(); i++)
        {
            if(_list[i] < min)
            {
                min = _list[i];
            }
        }
        return min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */