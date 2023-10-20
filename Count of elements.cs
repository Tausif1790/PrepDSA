Given an array A of N integers. 
Count the number of elements that have at least 1 elements greater than itself.

Input 1:
A = [3, 1, 2]
Input 2:
A = [5, 5, 3]


Example Output
Output 1:
2
Output 2:
1



class Solution
{
    public int solve(List<int> A)
    {
        int max_value = 0, max_count = 0;
        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] > max_value)
            {
                max_value = A[i];
                max_count = 1;
            }
            else if (A[i] == max_value)
            {
                max_count += 1;
            }
        }
        return A.Count - max_count;

        //-------------------------------------------------------------

        int n = A.Count;
        int maxElement = int.MinValue; // Initialize maxElement with a very small value
        int count = 0;

        // Find the maximum element in the array
        for (int i = 0; i < n; i++)
        {
            if (A[i] > maxElement)
            {
                maxElement = A[i];
            }
        }

        // Count elements that are less than the maximum element
        for (int i = 0; i < n; i++)
        {
            if (A[i] < maxElement)
            {
                count++;
            }
        }

        return count;


        // int n = A.Count;
        // int count = 0;

        // for(int i=0; i<n; i++){
        //     for(int j=0; j<n; j++){

        //         if(i!=j && A[i]<A[j]){
        //             count++;
        //             continue;
        //         }
        //     }
        // }

        // return count;
    }
}
