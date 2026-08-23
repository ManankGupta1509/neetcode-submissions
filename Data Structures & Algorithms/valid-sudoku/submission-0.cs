public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];
        for(int i=0; i<9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for(int r=0; r<9; r++)
        {
            for(int c=0; c<9; c++)
            {
                var val = board[r][c];
                if(val == '.')
                    continue;
                
                var boxIndex = (r/3)*3+(c/3);

                if(!rows[r].Add(val) || !cols[c].Add(val) || !boxes[boxIndex].Add(val))
                    return false;
            }
        }
        return true;
    }
}
