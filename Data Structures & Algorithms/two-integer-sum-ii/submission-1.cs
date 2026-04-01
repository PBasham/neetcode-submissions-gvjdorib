public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int s = 0;
        int e = numbers.Length - 1;

        while (s < e)
        {
            int start = numbers[s];
            int end = numbers[e];
            
            if(start + end == target) {return [s + 1, e + 1];}

            if (start + end > target) {e--;}
            else { s++;}

        }
        return [0,0];
    }
}
