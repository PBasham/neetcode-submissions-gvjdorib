public class Solution {
    public bool IsPalindrome(string s) {
        var newString = string.Concat(s.ToLower().Where(c => char.IsDigit(c) || char.IsLetter(c)));

        int left = 0;
        int right = newString.Length - 1;

        Console.WriteLine(newString);
        while(left < right)
        {
            
            if(newString[left++] != newString[right--]) {return false;}
        }
        
        return true;
    }

}
