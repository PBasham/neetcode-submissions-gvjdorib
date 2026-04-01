public class Solution {
    public bool IsPalindrome(string s) {
        int start = 0;
        int end = s.Length - 1;

        // int charArr = s.ToLower().Where(c => char.IsLetter(c) || char.IsDigit(c));
        while (start < end)
        {
            if(!char.IsLetter(s[start]) && !char.IsDigit(s[start])) {start++; continue;}
            if(!char.IsLetter(s[end]) && !char.IsDigit(s[end])) {end--; continue;}

            if(s.ToLower()[start] != s.ToLower()[end]) {return false;}
            start++;
            end--;
        }
        return true;
    }
}
