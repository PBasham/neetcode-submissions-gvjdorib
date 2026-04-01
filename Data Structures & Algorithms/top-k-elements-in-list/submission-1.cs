public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new();

        for(int i = 0; i < nums.Length; i++)
        {
            counts[nums[i]] = counts.GetValueOrDefault(nums[i]) + 1;
        }

        int[] results = new int[k];

        var sorted = counts.OrderByDescending(kvp => kvp.Value).ToList();

        for(int i = 0; i < k; i++) {
            results[i] = sorted[i].Key;
        }
        return results;
    }
}
