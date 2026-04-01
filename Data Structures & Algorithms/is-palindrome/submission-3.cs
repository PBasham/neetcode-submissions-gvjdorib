public class Solution {
    public bool IsPalindrome(string s) 
    {
        StringBuilder sb = new();
        foreach(var c in s) 
        {
            if(char.IsLetter(c) || char.IsNumber(c)) {sb.Append(c);}
        } 
        string newString = sb.ToString().ToLower();
        string reverseString = string.Concat(newString.Reverse());
        if (newString == reverseString) {return true;}
        return false;
    }
}
