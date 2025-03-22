public class MyQueue {
    // here i make two stack as when i push from one stack to the anohter one so it push from top to last so in the new pop stack it comes in the main order as they enter in the pushStack 
    Stack<int> popStack;
    Stack<int> pushStack;
    public MyQueue() {
        popStack = new Stack<int>();
        pushStack = new Stack<int>();
    }
    
    public void Push(int x) {
        pushStack.Push(x);
    }
    
    public int Pop() {
        if (popStack.Count == 0) {
            while (pushStack.Count > 0) {
                popStack.Push(pushStack.Pop());
            }
        }
        return popStack.Pop();
    }
    
    public int Peek() {
       if (popStack.Count == 0 || pushStack.Count() > popStack.Count()) {
            while (pushStack.Count > 0) {
                popStack.Push(pushStack.Pop());
            }
        }
        return popStack.Peek();
    }
    
    public bool Empty() {
        return pushStack.Count() == 0 && popStack.Count() ==0;
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