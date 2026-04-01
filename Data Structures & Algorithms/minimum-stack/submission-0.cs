public class MinStack {

    List<int> stack = new();

    public MinStack() {
        
    }
    
    public void Push(int val) {
        stack.Add(val);
    }
    
    public void Pop() {
        stack.RemoveAt(stack.Count - 1);
    }
    
    public int Top() {
        return stack[stack.Count - 1];
    }
    
    public int GetMin() {
        return stack.Min();
    }
}
