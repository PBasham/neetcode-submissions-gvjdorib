public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        

        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            Console.WriteLine($"left: {left}, right: {right}");
            int first = numbers[left];
            int second = numbers[right];
            int total =  second + first;
            Console.WriteLine($"{first} + {second} = {total} | target: {target}");

            if(total == target) {return [left + 1, right + 1];}

            if(total < target) {left++;}
            else {right--;}            
        }

        return [0,0];
    }
}
