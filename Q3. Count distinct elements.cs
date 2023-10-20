Given an array A of N integers, return the number of unique elements in the array.

Input 1: A = [3, 4, 3, 6, 6]
Output 1: 3

//----------------------------------------//

class Solution
{
    public int solve(List<int> A)
    {
        HashSet<int> sett = new HashSet<int>();
        //int n = A.Count;

        foreach (int el in A)
        {
            if (!sett.Contains(el))
            {
                sett.Add(el);
            }
        }

        return sett.Count;
    }
}
