public class Solution {
    public bool IsValid(string s) {
        List<char> stack = new();
        
        Dictionary<char, char> pairs = new() {
            {'(',')'},
            {'[',']'},
            {'{','}'}
        };

        for(int i = 0; i < s.Length; i++)
        {
            char current = s[i];

            if(pairs.ContainsKey(current)) { stack.Add(current); }
            else if (pairs.ContainsValue(current))
            {
                if (stack.Count == 0) {return false;}

                if (pairs[stack[stack.Count - 1]] != current) { return false;}
                
                stack.RemoveAt(stack.Count - 1);
            }
        }
        
        return stack.Count == 0;
    }
}
