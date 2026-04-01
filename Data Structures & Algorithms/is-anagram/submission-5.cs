public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length) {return false;}
        Dictionary<char, int> counts = new();

        for(int i = 0; i < s.Length; i++)
        {
            counts[s[i]] = counts.GetValueOrDefault(s[i]) + 1;
            counts[t[i]] = counts.GetValueOrDefault(t[i]) - 1;
        }

        foreach(var value in counts.Values)
        {
            if(value != 0) {return false;}
        }
        return true;
    }
}
