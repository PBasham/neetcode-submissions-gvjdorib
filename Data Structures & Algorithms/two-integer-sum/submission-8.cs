public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> targets = new();

        for(int i = 0; i < nums.Length; i++)
        {
            int curr = nums[i];
            int desired = target - curr;

            if(targets.ContainsKey(desired)) {return [targets[desired], i];}

            targets[curr] = i;
        }
        return [0,0];
    }
}
