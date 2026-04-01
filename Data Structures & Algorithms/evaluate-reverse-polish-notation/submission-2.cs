public class Solution {
    public int EvalRPN(string[] tokens) {
      Stack<int> stack = new();

      foreach(var token in tokens) 
      {
        if(int.TryParse(token, out int num)) {stack.Push(num);}
        else 
        {
          switch (token)
          {
            case "+":
              stack.Push(stack.Pop() + stack.Pop());
              break;
            case "-":
              stack.Push(-stack.Pop() + stack.Pop());
              break;
            case "*":
              stack.Push(stack.Pop() * stack.Pop());
              break;
            case "/":
              var first = stack.Pop();
              var second = stack.Pop();
              stack.Push(second / first);
              break;
          }
        }
      }


      return stack.Peek();
    }
}
