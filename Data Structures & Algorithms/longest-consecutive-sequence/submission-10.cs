public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> seenNumbers = new();
        foreach(int num in nums) { seenNumbers.Add(num); }   

        int hc = 0;

        foreach( int num in nums) 
        {   
            if(seenNumbers.Contains(num - 1)) {continue;}
            // I am a sequence start.
            
            int rc = 1;
            int current = num + 1;
            
            while(seenNumbers.Contains(current)) 
            {
                current = current + 1;
                rc++;
            }

            if(rc > hc) {hc = rc;}
        }
        return hc;
    }
}
