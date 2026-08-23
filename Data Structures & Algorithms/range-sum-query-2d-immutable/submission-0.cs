public class NumMatrix {
    private int[][] _matrix;
    public NumMatrix(int[][] matrix) {
        _matrix = matrix.Select(row => (int[])row.Clone()).ToArray();
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int result = 0;
        for(int i=row1 ; i<=row2 ; i++)
        {
            for(int j=col1; j<=col2; j++)
            {
                result += _matrix[i][j];
            }
        }
        return result;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */