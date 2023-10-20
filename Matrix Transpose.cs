A = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]   //ipt
[[1, 4, 7], [2, 5, 8], [3, 6, 9]]       //opt

class Solution
{
    public List<List<int>> solve(List<List<int>> A)
    {

        int rows = A.Count;
        int cols = A[0].Count;

        // we have to create new matrix if matrix is rectangular
        List<List<int>> transpose = new List<List<int>>();
        for (int col = 0; col < cols; col++)
        {
            List<int> transposedRow = new List<int>();
            for (int row = 0; row < rows; row++)
            {
                transposedRow.Add(A[row][col]);            // we choose outer loop col wise because 
            }
            transpose.Add(transposedRow);
        }
        return transpose;

        // this is for square matrix
        // int n = A.Count;
        // int m = A[0].Count;

        // for(int i=0; i < m; i++){
        //     for(int j=i+1; j<n; j++){

        //         int temp = A[i][j];
        //         A[i][j] = A[j][i];
        //         A[j][i] = temp;
        //     }
        // }

        // return A;
    }
}
