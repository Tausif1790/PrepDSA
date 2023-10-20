You are given an integer array A of length N.
You are also given a 2D integer array B with dimensions M x 2, where each row denotes a [L, R] query.
For each query, you have to find the sum of all elements from L to R indices in A (0 - indexed).
More formally, find A[L] +A[L + 1] + A[L + 2] + ... +A[R - 1] + A[R] for each query.

Example Input
Input 1:
A = [1, 2, 3, 4, 5]
B = [[0, 3], [1, 2]]

Input 2:
A = [2, 2, 2]
B = [[0, 0], [1, 2]]


Example Output
Output 1: [10, 5]
Output 2: [2, 4]


class Solution
{
    public List<long> rangeSum(List<int> A, List<List<int>> B)
    {

        List<long> pf = PreSum(A);
        int n = B.Count;
        //List<long> NewArr = new List<long>();
        List<long> NewArr = new List<long>();

        for (int i = 0; i < n; i++)
        {
            //int sum = 0;
            int l = B[i][0];
            int r = B[i][1];

            if (l == 0)
            {
                NewArr.Add(pf[r]);
            }
            else
            {
                NewArr.Add(pf[r] - pf[l - 1]);
            }
        }

        return NewArr;

    }

    List<long> PreSum(List<int> arr)
    {
        List<long> pf = new List<long>();
        //pf[0] = arr[0];                        // you cant do this because this element is not exist // array index out of bounds (exception)
        pf.Add(arr[0]);

        for (int i = 1; i < arr.Count; i++)
        {
            //pf[i] = pf[i-1] + arr[i];        // you cant do this because this element is not exist // array index out of bounds (exception)
            pf.Add(pf[i - 1] + arr[i]);
        }

        return pf;

    }
}
