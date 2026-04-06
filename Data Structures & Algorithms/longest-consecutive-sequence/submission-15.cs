public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numbers = new();

        foreach(var num in nums) {numbers.Add(num);}

        int maxLength = 0;

        //find sequence start;

        foreach(var num in numbers) 
        {
            if(numbers.Contains(num - 1)) {continue;}
            int count = 1;
            int currNumber = num;

            while(numbers.Contains(currNumber + 1))
            {
                count++;
                currNumber++;
            }

            maxLength = Math.Max(maxLength, count);
        }
        return maxLength;
    }
}
