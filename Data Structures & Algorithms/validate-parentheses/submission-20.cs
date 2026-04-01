public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 == 1) {return false;}
        Stack<char> stack = new();
        Dictionary<char, char> pairs = new() {
            {'[',']'},
            {'{','}'},
            {'(',')'}
        };

        foreach(char c in s)
        {
            if(pairs.ContainsKey(c))
            {
                stack.Push(c);
            }
            else {
                if(stack.Count == 0 || pairs[stack.Peek()] != c) {return false;}
                stack.Pop();
            }
        }
        return stack.Count == 0;
    }
}
