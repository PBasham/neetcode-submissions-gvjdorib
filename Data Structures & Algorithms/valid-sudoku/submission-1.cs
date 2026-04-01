public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new();

        for(int r = 0; r < board.Length; r++)
        {
            for(int c = 0; c < board[r].Length; c++)
            {
                char value = board[r][c];
                if (value == '.') {continue;}
                if(!seen.Add($"b{r/3}{c/3}:{value}")) {return false;}
                if(!seen.Add($"r{r}:{value}")) {return false;}
                if(!seen.Add($"c{c}:{value}")) {return false;}
            }
        }

        return true;
    }
}
