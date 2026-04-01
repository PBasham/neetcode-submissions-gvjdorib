public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) {return 0;}
        var sorted = nums.OrderBy(n => n).ToList();

        int hc = 1;
        int rc = 1;
        int lastHeld = sorted[0];
        for (int i = 1; i < sorted.Count; i++)
        {
            int current = sorted[i];
            Console.WriteLine($"sorted[{i}]: {current}. lastHeld: {lastHeld}. rc: {rc}. hc: {hc}");
            
            if(rc > hc) {hc = rc; Console.WriteLine("Updating count + 1");}

            if(current == lastHeld) {Console.WriteLine("Duplicate found.");continue;}

            if(current == lastHeld + 1) 
            {
                Console.WriteLine($"+ 1");
                lastHeld = current;
                rc++;
            }
            else 
            {
                Console.WriteLine("Resetting count");
                rc = 1;
                lastHeld = current;
            }
            
        }

        if(rc > hc) {hc = rc; Console.WriteLine("Updating count + 1");}
        
        return hc;
    }
}
