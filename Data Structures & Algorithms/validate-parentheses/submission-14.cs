public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new();
        Dictionary<char, char> pairs = new()
        {
          {'{','}'},
          {'(',')'},
          {'[',']'}
        };

        foreach( var c in s)
        {          
          if(pairs.ContainsKey(c)) { stack.Push(c); }
          else
          {
            if(stack.Count == 0 || pairs[stack.Peek()] != c) {return false;}
            stack.Pop();
          }
        }

        return stack.Count == 0;

    }
}
