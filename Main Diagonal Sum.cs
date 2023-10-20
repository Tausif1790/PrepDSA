//You are given a N X N integer matrix. You have to find the sum of all the main diagonal elements of A.

//Main diagonal of a matrix A is a collection of elements A[i, j] such that i = j.

class Solution
{
    public int solve(List<List<int>> A)
    {
        int n = A.Count;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += A[i][i];
        }

        return sum;
    }
}
