public class Solution {

    public string Encode(IList<string> strs) {
        if(strs.Count == 0) {return "";}
        StringBuilder sb = new();

        for(int i = 0; i < strs.Count; i++)
        {
            sb.Append(strs[i].Length);
            if(i != strs.Count - 1) {sb.Append(',');}
        }
        sb.Append(']').Append(string.Concat(strs));
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        if(string.IsNullOrWhiteSpace(s)) {return new();}
        int startIdx = s.IndexOf(']');

        var keys = s.Substring(0, startIdx).Split(',').Select(n => int.Parse(n)).ToList();
        startIdx++;
        List<string> results = new();
        foreach(var key in keys)
        {
            results.Add(s.Substring(startIdx, key));
            startIdx += key;
        }
        return results;
   }
}
