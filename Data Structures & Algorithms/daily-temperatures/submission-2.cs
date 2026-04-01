public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        // proper method.
        // Point is to use a stack to hold the idxs of values that 
        //don't have a larger value found yet, and iterate backwards 
        //and pop stack for all that are lower.
        Stack<int> stack = new();
        stack.Push(0);
        int[] results = new int[temperatures.Length];
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
