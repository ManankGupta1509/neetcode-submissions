public class NumMatrix {
    private int[][] _matrix;
    public NumMatrix(int[][] matrix) {
        int rows = matrix.Length;
        int cols =  matrix[0].Length;

        _matrix = new int[rows+1][];
        for(int i=0; i <= rows; i++)
        {
            _matrix[i] = new int[cols+1];
        }

        for(int i=1; i<=rows; i++)
        {
            for(int j=1; j<=cols; j++)
            {
                _matrix[i][j] = matrix[i-1][j-1] + _matrix[i-1][j] + _matrix[i][j-1] - _matrix[i-1][j-1];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int result = _matrix[row2+1][col2+1] - _matrix[row1][col2+1] - _matrix[row2+1][col1] + _matrix[row1][col1];
        return result;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */