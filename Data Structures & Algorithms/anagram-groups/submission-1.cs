public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        Dictionary<string, List<string>> strings = new();

        foreach(var str in strs) {
            string sorted = string.Concat(str.OrderBy(c => c));

            if(strings.ContainsKey(sorted)) {
                var group = strings[sorted];
                group.Add(str);
                strings[sorted] = group;
            }
            else {
                strings[sorted] = new() {str};
            }
        }


        return strings.Values.ToList();;
    }

}
