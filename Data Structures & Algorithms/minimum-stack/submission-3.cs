public class MinStack {

    Stack<int> stack = new();
    Stack<int> mins = new();
    
    public MinStack() {
        
    }
    
    public void Push(int val) {
        if(mins.Count == 0 || mins.Peek() >= val) {mins.Push(val);}
        stack.Push(val);
    }
    
    public void Pop() {
        if(stack.Pop() == mins.Peek()) {mins.Pop();}
        
    }
    
    public int Top() {
      return stack.Peek();
    }
    
    public int GetMin() {
        return mins.Peek();
    }
}
