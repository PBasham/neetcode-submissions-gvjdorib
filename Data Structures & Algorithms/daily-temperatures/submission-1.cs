public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        //Proper method...
        Stack<int> stack = new();
        int[] results = new int[temperatures.Length];

        stack.Push(0);

        for(int i = 1; i < temperatures.Length; i++)
        {
            while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                results[stack.Peek()] = i - stack.Pop();
            }
            
            stack.Push(i);
            
        }

        return results;
    }
}
