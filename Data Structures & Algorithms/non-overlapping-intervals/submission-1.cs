public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));

        int start = intervals[0][0];
        int end = intervals[0][1];
        int resultCount = 0;

        for(int i = 1; i < intervals.Length; i++)
        {
            var current = intervals[i];
            int s = current[0];
            int e = current[1];

            if(s < end) 
            {
                resultCount++;
                end = Math.Min(end, e);
                continue;
            }
            start = s;
            end = e;
        }
        return resultCount;
    }
}
