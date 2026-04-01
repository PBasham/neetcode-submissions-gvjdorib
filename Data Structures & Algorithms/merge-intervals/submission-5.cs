public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));
        List<int[]> results = new();
        
        int left = intervals[0][0];
        int right = intervals[0][1];

        for(int i = 1; i < intervals.Length; i++)
        {
            var interval = intervals[i];
            if(interval[0] > right) 
            {
                results.Add([left,right]);
                left = interval[0];
                right = interval[1];
                continue;
            }

            right = Math.Max(right, interval[1]);
        }
        results.Add([left,right]);
        return results.ToArray();
    }
}
