public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] products = new int[nums.Length];
        products[0] = 1;

        for(int i = 1; i < nums.Length; i++)
        {
            products[i] = products[i - 1] * nums[i - 1];
        }

        int suffix = 1;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            products[i] *= suffix;
            suffix *= nums[i];
        }
        return products;
    }
}
