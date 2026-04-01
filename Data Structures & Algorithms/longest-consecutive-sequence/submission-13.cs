public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> seenNumbers = new();
        foreach(int num in nums) { seenNumbers.Add(num); }   

        int hc = 0;

        foreach( int num in nums) 
        {   
            if(seenNumbers.Contains(num - 1)) {continue;}
            int rc = 1;
            int current = num + 1;
            
            while(seenNumbers.Contains(current)) 
            {
                current++;
                rc++;
            }

            if(rc > hc) {hc = rc;}
        }
        return hc;
    }
}
