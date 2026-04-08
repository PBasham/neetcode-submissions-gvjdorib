public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new();

        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[i].Length; j++)
            {
                char val = board[i][j];
                if(val == '.') {continue;}
                Console.WriteLine($"i: {i}, j: {j}, val: {val}");
                if(!seen.Add($"b{i/3}{j/3}:{val}")) {return false;}
                if(!seen.Add($"r{i}:{val}")) {return false;}
                if(!seen.Add($"c{j}:{val}")) {return false;}
            }
        }

        return true;
    }
}
