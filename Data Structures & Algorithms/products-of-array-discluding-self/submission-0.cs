public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prods = new int[nums.Length];

        prods[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            prods[i] = prods[i - 1] * nums[i - 1];
        }

        int suffix = 1;
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            prods[i] *= suffix;
            suffix *= nums[i];
        }
        return prods;
    }
}
