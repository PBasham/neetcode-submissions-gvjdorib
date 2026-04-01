public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));

        int start = intervals[0][0];
        int end = intervals[0][1];

        List<int[]> results = new();

        for(int i = 1; i < intervals.Length; i++)
        {
            var current = intervals[i];

            if(current[0] > end)
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
