public class Solution {
    public int[][] Merge(int[][] intervals) {

        if (intervals.Length == 0) {return Array.Empty<int[]>();}

        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));

        List<int[]> results = new();
        
        int start = intervals[0][0];
        int end = intervals[0][1]; 

        for(int i = 0; i < intervals.Length; i++)
        {
            var current = intervals[i];

            if (current[0] > end) 
            {
                results.Add(new int[] {start, end});
                start = current[0];
                end = current[1];
            }

            end = Math.Max(end, current[1]);
        }

        results.Add(new int[] {start, end});

        return results.ToArray();
    }
}
