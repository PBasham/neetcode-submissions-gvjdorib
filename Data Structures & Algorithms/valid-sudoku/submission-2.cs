public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new();

        for(int r = 0; r < board.Length; r++)
        {
            for(int c = 0; c < board[r].Length; c++)
            {
                if(board[r][c] == '.') {continue;}
                Console.WriteLine($"b{r/3}{c/3}:{board[r][c]}");
                if(!seen.Add($"b{r/3}{c/3}:{board[r][c]}")) {return false;}
                Console.WriteLine($"r{r}:{board[r][c]}");
                if(!seen.Add($"r{r}:{board[r][c]}")) {return false;}
                Console.WriteLine($"c{c}:{board[r][c]}");
                if(!seen.Add($"c{c}:{board[r][c]}")) {return false;}
            }
        }
        return true;
    }
}
