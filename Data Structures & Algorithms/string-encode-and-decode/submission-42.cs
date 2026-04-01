public class Solution {

    public string Encode(IList<string> strs) {
        if(strs.Count == 0) {return "";}
        StringBuilder sb = new();
        sb.Append(string.Join(",",strs.Select(s => s.Length)));
        sb.Append("]");
        sb.Append(string.Join("",strs));
        
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        if(s == "") {return new();}
        int endIdx = s.IndexOf("]");
        List<string> decoded = new();

        List<int> counts = s.Substring(0, endIdx)
            .Split(",")
            .Select(n => int.Parse(n))
            .ToList();
        
        int startIdx = endIdx + 1;
        foreach(var count in counts)
        {
            decoded.Add(s.Substring(startIdx, count));
            startIdx += count;
        }

        return decoded;
   }
}
