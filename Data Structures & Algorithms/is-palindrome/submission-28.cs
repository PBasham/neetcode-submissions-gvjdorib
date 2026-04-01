public class Solution {
    public bool IsPalindrome(string s) {
        var newString = string.Concat(s.Where(c => char.IsLetter(c) || char.IsDigit(c))).ToLower();

        Console.WriteLine(newString);
        int left = 0;
        int right = newString.Length - 1;

        while (left < right)
        {
            if (newString[left++] != newString[right--]) {return false;}
        }
        return true;
    }
}
