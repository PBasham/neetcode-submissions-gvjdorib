public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        if (strs.Length == 0) {return new();}

        Dictionary<string, List<string>> groups = new();

        foreach(var str in strs)
        {
            var sorted = string.Concat(str.OrderBy(c => c));
            if(!groups.TryGetValue(sorted, out var group)) 
            {
                groups[sorted] = group = new();
            }
            group.Add(str);
        }

        return groups.Values.ToList();
    }
}
