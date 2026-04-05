public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {

        Dictionary<int, int> counts = new();

        foreach(int num in nums)
        {
            counts[num] = counts.GetValueOrDefault(num) + 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach(var kvp in counts)
        {
            var freq = kvp.Value;
            var key = kvp.Key;

            if(buckets[freq] == null) {buckets[freq] = new List<int>();}

            buckets[freq].Add(key);
        }
        
        int[] results = new int[k];
        int count = 0;
        for(int i = nums.Length; i >= 0; i--)
        {
            if(count == k) {break;}
            var bucket = buckets[i];

            if(bucket == null) {continue;}

            foreach(var num in bucket) 
            {
                if(count == k) {break;}

                results[count++] = num;
            }

        }

        return results;
    }
}
