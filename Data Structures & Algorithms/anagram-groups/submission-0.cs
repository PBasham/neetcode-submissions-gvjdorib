public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs.Length == 1) {return new List<List<string>>() {strs.ToList()};}

        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        for(int i = 0; i < strs.Length; i++)
        {
            string str = strs[i];
            string sorted = string.Concat(str.OrderBy(c=>c));

            if(groups.ContainsKey(sorted))
            {
                var group = groups[sorted];
                group.Add(str);
                groups[sorted] = group;
            }
            else { groups[sorted] = new List<string> {str};}
        }

        return groups.Values.ToList();
    }
}
