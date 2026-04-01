public class Solution {

    public string Encode(IList<string> strs) {
        if (strs.Count == 0) {return "";}

        StringBuilder sb = new();
        sb.Append(string.Join(",", strs.Select(s => s.Length)));
        sb.Append("]");

        foreach(var s in strs) {sb.Append(s);}
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        if(s == "") {return new();}
        int endIdx = s.IndexOf("]");

        List<int> charCounts = s.Substring(0, endIdx).Split(",").Select(n => int.Parse(n)).ToList();
        List<string> results = new();
        int pos = ++endIdx;
        foreach(var count in charCounts) 
        { 
            results.Add(s.Substring(pos, count));
            pos += count;
        }
        return results;
   }
}
