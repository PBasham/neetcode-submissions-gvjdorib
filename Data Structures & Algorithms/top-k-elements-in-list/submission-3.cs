public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new();

        foreach(int num in nums) {counts[num] = counts.GetValueOrDefault(num) + 1;}

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach(var kvp in counts)
        {
            int freq = kvp.Value;
            if(buckets[freq] == null) {buckets[freq] = new List<int>();}
            buckets[freq].Add(kvp.Key);
        }

        int[] results = new int[k];
        int idx = 0;
        for(int i = buckets.Length - 1; i > 0 && idx < k; i--)
        {
            var bucket = buckets[i];
            if(bucket == null) {continue;}
            foreach(var num in bucket)
            {
                if(idx >= k) {break;}
                results[idx++] = num;
            }
        }

        return results;
    }
}
