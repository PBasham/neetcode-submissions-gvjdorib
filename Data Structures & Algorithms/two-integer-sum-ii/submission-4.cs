public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        { 
            int total = numbers[left] + numbers[right];
            if(total == target) {return [left + 1, right + 1];}

            if(total < target) {left++;}
            else {right--;}
        }

        return [0,0];
    }
}
