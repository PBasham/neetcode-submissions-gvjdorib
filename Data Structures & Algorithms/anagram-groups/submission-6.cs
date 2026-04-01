public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs.Length == 0) {return new();}
        Dictionary<string, List<string>> groups = new();

        foreach(string str in strs)
        {
            int[] frequency = new int[26];

            foreach(char c in str)
            {
                frequency[c - 'a']++;
            }

            string freqKey = string.Join(',', frequency);
            if(!groups.ContainsKey(freqKey)) {groups[freqKey] = new List<string>();}

            groups[freqKey].Add(str);

        }

        return groups.Values.ToList();
    }
}
