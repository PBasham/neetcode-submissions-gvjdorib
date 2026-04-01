public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs.Length == 0) {return new();}

        Dictionary<string, List<string>> groups = new();

        foreach(var str in strs)
        {
            int[] frequency = new int[26];

            foreach(var c in str) 
            {
                frequency[c - 'a']++;
            }
            string freqKey = string.Join(",", frequency);
            if(!groups.TryGetValue(freqKey, out var group))
            {
                groups[freqKey] = group = new List<string>();
            }

            group.Add(str);
        }

        return groups.Values.ToList();
    }
}
