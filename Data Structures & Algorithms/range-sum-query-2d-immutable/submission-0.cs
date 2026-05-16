public class NumMatrix {
    int[][] matrix;

    public NumMatrix(int[][] matrix) {
        this.matrix = matrix;
    }

    public int ZeroSum(int r1, int c1, int[][] cum_sum_mat) {
        int sum = 0;
        if (r1 == 0) {
            return cum_sum_mat[r1][c1];
        } else {
            // Your logic: summing up the horizontal row prefix values vertically from row 0 to r1
            for (int i = 0; i <= r1; i++) {
                sum += cum_sum_mat[i][c1];
            }
            return sum;
        }
    }

    public int SumRegion(int row1, int col1, int row2, int col2) {
        // Fixed: Length gets the total elements, GetLength(0) gets the row count for multidimensional arrays.
        // For jagged arrays (int[][]), matrix.Length gives rows, and matrix[0].Length gives columns.
        int x = matrix.Length;
        int y = matrix[0].Length;
        
        // Initializing the jagged array properly in C#
        int[][] cum_sum_mat = new int[x][];
        for (int i = 0; i < x; i++) {
            cum_sum_mat[i] = new int[y];
            int s = 0;
            for (int j = 0; j < y; j++) {
                s += matrix[i][j];
                cum_sum_mat[i][j] = s;
            }
        }

        // Applying your ZeroSum logic with boundary checks to prevent out-of-bounds errors
        int totalCorner = ZeroSum(row2, col2, cum_sum_mat);
        int leftChunk = (col1 > 0) ? ZeroSum(row2, col1 - 1, cum_sum_mat) : 0;
        int topChunk = (row1 > 0) ? ZeroSum(row1 - 1, col2, cum_sum_mat) : 0;
        int overlapChunk = (row1 > 0 && col1 > 0) ? ZeroSum(row1 - 1, col1 - 1, cum_sum_mat) : 0;

        return totalCorner - leftChunk - topChunk + overlapChunk;
    }
}