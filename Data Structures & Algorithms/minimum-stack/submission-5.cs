public class MinStack {

    Stack<int> stack = new();
    Stack<int> minStack = new();

    public MinStack() {
        
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minStack.Count == 0 || minStack.Peek() >= val) {minStack.Push(val);}
    }
    
    public void Pop() {
        if(minStack.Peek() == stack.Pop()) {minStack.Pop();}
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
