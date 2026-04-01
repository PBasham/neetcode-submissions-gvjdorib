public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int, int> seen = new();

        foreach(int num in nums) { seen[num] = seen.GetValueOrDefault(num) + 1;}

         List<int>[] buckets = new List<int>[nums.Length + 1];

         foreach(var kvp in seen) {
            
            var value = kvp.Value;

            if(buckets[value] == null) {buckets[value] = new List<int>();}

            buckets[value].Add(kvp.Key);
         }

        int[] results = new int[k];
        int count = 0;
        
        for(int i = buckets.Length - 1; i >= 0; i--)
        {
            if(count == k) {break;}
            if(buckets[i] == null) {continue;}
            foreach(int num in buckets[i])
            {
                if(count == k) {break;}
                results[count++] = num;
            }
        }

        return results;
    }
}
