Given an array of integers A, find and return whether the given array contains
a non-empty subarray with a sum equal to 0.
If the given array contains a sub-array with sum zero return 1, else return 0.

Problem Constraints
1 <= |A| <= 100000
-10^9 <= A[i] <= 10 ^ 9

Input Format: The only argument given is the integer array A.

Output Format:
Return whether the given array contains a subarray with a sum equal to 0.

Example Input
Input 1: A = [1, 2, 3, 4, 5]
Input 2: A = [4, -1, 1]

Example Output
Output 1: 0
Output 2: 1

//------------------Day13_Page16------------------//
class Solution
{
    public int solve(List<int> A)
    {
        List<long> pf = this.PreSum(A);

        // Create a HashSet to store unique prefix sums
        HashSet<long> sett = new HashSet<long>();

        foreach (long k in pf)
        {
            if (k == 0)
            {
                return 1;
            }

            sett.Add(k);            // if statement
        }

        // If the count of prefix sums matches the count of unique prefix sums, return 0
        if (pf.Count == sett.Count)
        {
            return 0;
        }
        else
        {
            return 1;       
        }
    }

    List<long> PreSum(List<int> arr)
    {
        List<long> pf = new List<long>();
        pf.Add(arr[0]);

        for (int i = 1; i < arr.Count; i++)
        {
            pf.Add(pf[i - 1] + arr[i]);
        }
        return pf;
    }
}

//Brute Force
//Go to each aubanay
//check for sum = 0
//TC > O(n)
