public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> seen = new();

        foreach(var num in nums) {seen[num] = seen.GetValueOrDefault(num) + 1;}

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach(var kvp in seen) 
        {
            var freq = kvp.Value;

            if(buckets[freq] == null) {buckets[freq] = new List<int>();}
            buckets[freq].Add(kvp.Key);
        }
        int[] results = new int[k];
        int idx = 0;
        for(int i = buckets.Length - 1; i > 0; i--)
        {
            if(buckets[i] == null) {continue;}
            if(idx == k) {break;}

            var bucket = buckets[i];

            foreach(var num in bucket)
            {
                
                if(idx == k) {break;}
                results[idx++] = num;
                
            }
        }
        return results;
    }
}
