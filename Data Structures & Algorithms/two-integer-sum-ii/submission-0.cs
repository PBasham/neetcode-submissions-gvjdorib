public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> lookingFor = new();

        for(int i = 0; i < numbers.Length; i++)
        {
            int current = numbers[i];
            int needed = target - current;
            if(lookingFor.ContainsKey(needed))
            {
                return [lookingFor[needed], i + 1];
            }

            lookingFor[current] = i + 1;
        }
        return [0,0];
    }
}
