public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++)
        {
            int firstValue = nums[i];

            for(int j = 0; j < nums.Length; j++) {
                if(j == i) {continue;}
                int secondValue = nums[j];

                if (nums[i] + nums[j] == target) {return [i,j];}

            }
        }
        return [0,0];
    }
}
