public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {return false;}

        Dictionary<char,int> counts = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++)
        {
            if(counts.ContainsKey(s[i])) {counts[s[i]]++;}
            else {counts[s[i]] = 1;}
            
            if(counts.ContainsKey(t[i])) {counts[t[i]]--;}
            else {counts[t[i]] = -1;}
        }

        foreach(var value in counts.Values)
        {
            if(value != 0) {return false;}
        }

        return true;
    }
}
