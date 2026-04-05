public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new();

        for(int i = 0; i < nums.Length; i++)
        {
            int curr = nums[i];
            int lookingFor = target - curr;

            if(seen.ContainsKey(lookingFor))
            {
                return [seen[lookingFor], i];
            }
            seen[curr] = i;
        }

        return [0,0];
        
    }
}
