public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> desired = new();

        for(int i = 0; i < nums.Length; i++)
        {
            int current = nums[i];
            int lookingFor = target - current;

            if(desired.ContainsKey(lookingFor)) {return [desired[lookingFor], i];}
            desired[current] = i;
        }

        return [0,0];
    }
}
