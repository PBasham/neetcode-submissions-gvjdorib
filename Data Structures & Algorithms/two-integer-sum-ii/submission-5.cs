public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int start = 0;
        int end = numbers.Length - 1;

        while (start < end)
        {
            int val = numbers[start] + numbers[end];
            if(val == target) {return [start + 1, end + 1];}

            if (val < target) {start++;}
            else {end--;}
        }

        return [0,0];
    }
}
