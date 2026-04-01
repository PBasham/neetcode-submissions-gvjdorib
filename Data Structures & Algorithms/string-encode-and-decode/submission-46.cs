public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new();
        if(strs.Count == 0) {return string.Empty;}
        for(int i = 0; i < strs.Count; i++)
        {
            sb.Append(strs[i].Length);
            if(i < strs.Count - 1) {sb.Append(",");}
        }
        sb.Append("]");
        return string.Concat(sb.ToString(), string.Concat(strs));
    }

    public List<string> Decode(string s) {
        if(s == string.Empty) {return new();}
        int startIdx = s.IndexOf("]");
        List<string> results = new();
        List<int> counts = s.Substring(0,startIdx)
            .Split(",")
            .Select(c => int.Parse(c))
            .ToList();

        startIdx = startIdx + 1;
        foreach(int count in counts)
        {
            results.Add(s.Substring(startIdx, count));
            startIdx += count;
        }

        return results;
   }
}
