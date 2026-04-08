public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {return false;}
        Dictionary<char, int> seen = new();

        for(int i = 0; i < s.Length; i++)
        {
            seen[s[i]] = seen.GetValueOrDefault(s[i]) + 1;
            seen[t[i]] = seen.GetValueOrDefault(t[i]) - 1;
        }

        foreach(int num in seen.Values) {if(num != 0) {return false;}}

        return true;
    }
}
