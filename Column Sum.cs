//You are given a 2D integer matrix A, return a 1D integer array containing column-wise sums of original matrix.

//[1,2,3,4]     //input
//[5,6,7,8]
//[9,2,3,4]

//{ 15,10,13,16}    //opt

class Solution
{
    public List<int> solve(List<List<int>> A)
    {
        int n = A.Count;
        int m = A[0].Count;
        List<int> AA = new List<int>();

        for (int j = 0; j < m; j++)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += A[i][j];
            }

            AA.Add(sum);
        }

        return AA;
    }
}
