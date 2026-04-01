public class Solution {

    public string Encode(IList<string> strs) {
        int sentanceCount = strs.Count;
        if(strs.Count == 0) {return null;}
        //if(strs.Count == 1) {return strs[0];}
        
        // Get 
        List<int> counts = new List<int>();

        string newString = string.Empty;

        for(int i = 0; i < strs.Count; i++)
        {
            string curr = strs[i];
            newString += curr.Split().Length;
            if(i < strs.Count - 1) {newString +=',';}
        }
        newString +=']';

        return string.Concat(newString, string.Join(" ", strs));
    }

    public List<string> Decode(string s) {
        Console.WriteLine($"Decode: {s}");
        if (s == null) {return new();}
        if (s == "") {return new() {""};}
        int count = 0;
        
        while(true)
        {
            char currentString = s[count];
            if (currentString == ']') {break;}
            count++;
        }

        List<int> counts = s.Substring(0, count).Split(",").Select(n => int.Parse(n)).ToList();

        int position = 0;
        List<string> newStrings = s.Substring(count + 1).Split().ToList();
        List<string> parsedStrings = new List<string>();
        for(int i = 0; i < counts.Count; i++)
        {
            StringBuilder sb = new();
            int wordCount = counts[i];
            while(wordCount > 0)
            {
                sb.Append(newStrings[position]);
                if(wordCount > 1) {sb.Append(" ");}
                wordCount--;
                position++;
            }
            parsedStrings.Add(sb.ToString());
        }



        return parsedStrings;
   }
}
