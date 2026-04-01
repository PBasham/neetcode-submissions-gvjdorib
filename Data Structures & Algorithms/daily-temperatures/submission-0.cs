public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        for(int i = 0; i < temperatures.Length; i++)
        {

            var temp = temperatures[i];
            //Iterate forward until we find a greater temp
            int nextIdx = i + 1;
            int count = 0;
            Console.WriteLine($"temp: {temp}");
            while(nextIdx < temperatures.Length)
            {
                Console.WriteLine($"nextIdx: {nextIdx}");
                if(temperatures[nextIdx] > temp) { Console.WriteLine($"count = nextIdx - i: {nextIdx} - {i}");count = nextIdx - i; break;}
                nextIdx++;
            }
            Console.WriteLine($"Count until next: {count}");
            temperatures[i] = count;
        }
        return temperatures;
    }
}
