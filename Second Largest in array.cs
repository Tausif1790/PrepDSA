You are given an integer array A. You have to find the second largest element/value in the array
or report that no such element exists.

Return the second largest element. If no such element exist then return -1.

Input 1:
A = [2, 1, 2]
Input 2:
A = [2]

Output 1: 1
Output 2: -1


class Solution
{
	public int solve(List<int> A)
	{
		//A.Sort();
		int n = A.Count;
		int lar1 = int.MinValue;
		int lar2 = -1;
		int idx = 0;

		//find the largest element
		for (int i = 0; i <= n - 1; i++)
		{

			if (A[i] > lar1)
			{
				lar1 = A[i];
			}
		}

		for (int i = 0; i <= n - 1; i++)
		{

			if (lar1 != A[i] && A[i] > lar2)
			{
				lar2 = A[i];
			}
		}

		return lar2;
	}
}
