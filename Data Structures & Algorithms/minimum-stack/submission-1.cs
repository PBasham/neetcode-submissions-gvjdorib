public class MinStack {

    List<int> stack = new();
    
    List<int> mins = new();

    public MinStack() {
        
    }
    
    public void Push(int val) {
        if(mins.Count == 0 || mins[mins.Count - 1] >= val) {mins.Add(val);}
        stack.Add(val);
    }
    
    public void Pop() {
        if (stack[stack.Count - 1] == mins[mins.Count - 1]) {mins.RemoveAt(mins.Count -1);}
        stack.RemoveAt(stack.Count - 1);
    }
    
    public int Top() {
        return stack[stack.Count - 1];
    }
    
    public int GetMin() {
        return mins[mins.Count - 1];
    }
}
