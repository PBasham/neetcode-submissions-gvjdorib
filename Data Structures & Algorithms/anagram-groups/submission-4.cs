public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new();

        foreach(string str in strs)
        {
            var sorted = string.Concat(str.OrderBy(c => c));
            Console.WriteLine($"Sorted: {sorted}");
            if(!groups.ContainsKey(sorted)) { Console.WriteLine($"Creating new group in dict"); groups[sorted] = new List<string>();}
            
            Console.WriteLine($"Adding: {str} to groups[{sorted}]");
            groups[sorted].Add(str);

        }

        return groups.Values.ToList();
    }
}
