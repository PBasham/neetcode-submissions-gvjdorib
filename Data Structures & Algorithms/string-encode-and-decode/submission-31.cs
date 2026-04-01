public class Solution {

    public string Encode(IList<string> strs) {
        if (strs.Count == 0) {return null;}
        if (strs.Count == 1 && strs[0] == "") {return "";}
        string newString = string.Empty;
        for(int i = 0; i < strs.Count; i++)
        {
            newString += $"{strs[i].Length}";
            if(i < strs.Count - 1) {newString += ",";}
        }
        newString += "]";

        newString += string.Join(" ", strs);
        return newString;
    }

    public List<string> Decode(string s) {
        Console.WriteLine($"Decode: {s}");
        if (s == null) {return new();}
        if (s == "") { return new() {""};}
        int count = 0;
        while(true)
        {
            char current = s[count];
            if (current == ']') {break;}
            count++;
        }
        List<int> charCounts = s.Substring(0,count).Split(",").Select(n => int.Parse(n)).ToList();
        count++;
        List<string> returnStrings = new();
        int idx = 0;
        while(count <= s.Length)
        {
            int length = charCounts[idx++];
            if (length == 0)  { returnStrings.Add(""); }
            else  { returnStrings.Add(s.Substring(count, length)); }
            count += (length + 1);
        }

        return returnStrings;
   }
}
