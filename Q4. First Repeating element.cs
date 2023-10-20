Given an integer array A of size N, find the first repeating element in it.
We need to find the element that occurs more than once and whose index of the first occurrence is the smallest.
If there is no repeating element, return -1.

Input 1: A = [10, 5, 3, 4, 3, 5, 6]
Input 2: A = [6, 10, 5, 4, 9, 120]

Output 1: 5
Output 2: -1


//--------------------------------------------------//
class Solution
{
    public int solve(List<int> A)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        // // Iterate through the input list to populate the dictionary with element frequencies.
        foreach (int el in A)
        {
            if (dict.ContainsKey(el))
            {
                int freq = dict[el];          // If the element is already in the dictionary, increment its frequency.
                dict[el] = freq + 1;
            }
            else
            {
                dict[el] = 1;                // If the element is not in the dictionary, add it with a frequency of 1.
            }
        }

        // Iterate through the input list again to find the first element with a frequency greater than 1.  
        for (int i = 0; i < A.Count; i++)
        {
            if (dict[A[i]] > 1)
            {
                return A[i];                // Return the first element with a frequency greater than 1 (a duplicate).
            }
        }

        return -1;
    }
}
