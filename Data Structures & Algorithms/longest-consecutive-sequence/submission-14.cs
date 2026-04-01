public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> seen = new();
        foreach(int num in nums) {seen.Add(num);}

        int hc = 0;

        foreach( int num in nums)
        {
            if(seen.Contains(num - 1)) {continue;}
            int rc = 0;
            int current = num;
            
            while(seen.Contains(current))
            {
                current++;
                rc++;
            }
            if(rc > hc) {hc = rc;}
        }
        return hc;
    }
}
