//Give a N * N square matrix A, return an array of its anti-diagonals. Look at the example for more details.

//opt :-Return a 2D integer array of size (2 * N-1) *N, representing the anti-diagonals of input array A.
//	The vacant spaces in the grid should be assigned to 0.

//1 2 3   ipt
//4 5 6
//7 8 9

//1 0 0   opt
//2 4 0
//3 5 7
//6 8 0
//9 0 0





class Solution
{
	public List<List<int>> diagonal(List<List<int>> A)
	{
		int l = A.Count; // Get the length of the input list of lists
		List<List<int>> res = new List<List<int>>(); // Initialize the result list

		// Iterate through diagonals
		for (int i = 0; i < 2 * l - 1; i++)
		{
			int offset = i < l ? 0 : i - l + 1; // Calculate the starting offset for the diagonal
			List<int> row = new List<int>(); // Initialize a row for the diagonal traversal
			int k = 0;

			// Traverse the current diagonal
			for (int j = offset; j <= i - offset; j++)
			{
				row.Add(A[j][i - j]); // Add the element from the diagonal to the row
				k++;
			}

			// Fill the remaining elements in the row with zeros
			for (int j = k; j < l; j++)
			{
				row.Add(0);
			}

			// Add the row to the result list
			res.Add(row);
		}

		return res; // Return the diagonal traversal result
	}
}
