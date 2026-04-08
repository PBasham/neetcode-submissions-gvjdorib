public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numbers = new();

        foreach(var num in nums) {numbers.Add(num);}

        int maxLength = 0;

        foreach(var num in numbers)
        {
            if (numbers.Contains(num - 1)) {continue;}

            int curr = num + 1;
            int count = 1;
            while(numbers.Contains(curr))
            {
                curr++;
                count++;
            }
            maxLength = Math.Max(maxLength, count);
        }
        return maxLength;
    }
}
