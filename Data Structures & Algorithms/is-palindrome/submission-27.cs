public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new ();
        
        foreach(var c in s.ToLower())
        {
            if(char.IsLetter(c) || char.IsDigit(c)) {sb.Append(c);}
        }

        string newString = sb.ToString();
        Console.WriteLine($"newString: {newString}");
        
        
        return newString == string.Concat(newString.Reverse());
    }
}
