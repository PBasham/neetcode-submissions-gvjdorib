public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> seen = new List<int>();

        foreach(int num in nums)
        {
            if(seen.Contains(num)) {return true;}
            seen.Add(num);
        }
        return false;
    }
}