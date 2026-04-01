public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Console.WriteLine($"Target: {target}");
        Dictionary<int, int> seen = new();

        for(int i = 0; i < nums.Length; i++)
        {
            int current = nums[i];
            int diff = target - current;          
            
            Console.WriteLine($"nums[{i}]: {nums[i]}");
            
            Console.WriteLine($"diff: {diff}");

            if(seen.ContainsKey(current))
            {
                return [seen[current],i];
            }
            Console.WriteLine($"diff not found: setting seen[{diff}] = {i}");
            seen[diff] = i;

        }

        return [0,0];
    }
}
