public class Solution {
    public bool IsPalindrome(string s) 
    {
        Console.WriteLine($"s: {s}");
        //remove special characters
        //make lowercase
        StringBuilder sb = new();
        foreach(var c in s) 
        {
            if(char.IsLetter(c) || char.IsNumber(c)) {sb.Append(c);}
        } 
        string newString = sb.ToString().ToLower();
        string reverseString = string.Concat(newString.Reverse());
        Console.WriteLine($"n: {newString}");
        Console.WriteLine($"r: {reverseString}");
        if (newString == reverseString) {return true;}
        return false;
    }
}
