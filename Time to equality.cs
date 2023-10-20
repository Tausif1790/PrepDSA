Given an integer array A of size N. In one second, you can increase the value of one element by 1.
Find the minimum time in seconds to make all elements of the array equal.

First argument is an integer array A.

Output Format
Return an integer denoting the minimum time to make all elements equal.

Example Input
A = [2, 4, 1, 3, 2]

Example Output
8


class Solution
{
    public int solve(List<int> A)
    {
        int n = A.Count;
        int val = 0;
        for (int i = 0; i < n; i++)
        {
            val = Math.Max(val, A[i]);
        }
        int ans = 0;
        for (int i = 0; i < n; i++)
        {
            ans += val - A[i];
        }
        return ans;
    }
}
