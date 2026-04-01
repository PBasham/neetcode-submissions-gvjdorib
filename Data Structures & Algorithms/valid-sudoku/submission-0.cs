public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new();

        for(int r = 0; r < board.Length; r++)
        {
            for(int c = 0; c < board[r].Length; c++)
            {
                char value = board[r][c];
                if (value == '.') {continue;}
                Console.WriteLine($"b{r/3}{c/3}:{value}");
                if(!seen.Add($"b{r/3}{c/3}:{value}")) {Console.WriteLine($"Returning false: b{r/3}{c/3}:{value} already found"); return false;}
                Console.WriteLine($"r{r}:{value}");
                if(!seen.Add($"r{r}:{value}")) {Console.WriteLine($"Returning false: r{r}:{value} already found"); return false;}
                Console.WriteLine($"c{c}:{value}");
                if(!seen.Add($"c{c}:{value}")) {Console.WriteLine($"Returning false: c{c}:{value} already found"); return false;}
            }
        }

        return true;
    }
}
