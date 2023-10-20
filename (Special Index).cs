Given an array, arr[] of size N, the task is to find the count of array indices such that removing an element
from these indices makes the sum of even-indexed and odd-indexed array elements equal.

Input Format
First argument contains an array A of integers of size N

Output Format
Return the count of array indices such that removing an element from these indices makes the sum of even-indexed and odd-indexed array elements equal.

Example Input
Input 1: A = [2, 1, 6, 4]
Input 2: A = [1, 1, 1]

Example Output
Output 1: 1
Output 2: 3

//----------------------------------------------------------------------------------

class Solution
{
    private int cntIndexesToMakeBalance(int[] arr, int n)
    {
        if (n == 1)
        {
            return 1;
        }

        if (n == 2)
            return 0;

        int sumEven = 0;
        int sumOdd = 0;

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                sumEven += arr[i];
            }
            else
            {
                sumOdd += arr[i];
            }
        }

        int currOdd = 0;
        int currEven = arr[0];
        int res = 0;
        int newEvenSum = 0;
        int newOddSum = 0;

        for (int i = 1; i < n - 1; i++)
        {
            if (i % 2 == 1)
            {
                currOdd += arr[i];
                newEvenSum = currEven + sumOdd
                             - currOdd;
                newOddSum = currOdd + sumEven
                            - currEven - arr[i];
            }
            else
            {
                currEven += arr[i];
                newOddSum = currOdd + sumEven
                            - currEven;
                newEvenSum = currEven + sumOdd
                             - currOdd - arr[i];
            }
            if (newEvenSum == newOddSum)
            {
                res++;
            }
        }
        if (sumOdd == sumEven - arr[0])
        {
            res++;
        }
        if (n % 2 == 1)
        {
            if (sumOdd == sumEven - arr[n - 1])
            {
                res++;
            }
        }
        else
        {
            if (sumEven == sumOdd - arr[n - 1])
            {
                res++;
            }
        }
        return res;
    }

    public int solve(List<int> A)
    {
        int n = A.Count;
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = A[i];
        return cntIndexesToMakeBalance(a, n);
    }
}


public int solve(List<int> A)
{
    // int n = A.Count;
    // int count = 0;

    // for(int i=0; i<n; i++){
    //     int sumEven = 0;
    //     int sumOdd = 0;

    //     for(int j=0; j<n; j++){

    //         if(j < i && j%2 == 0){
    //              sumEven = sumEven + A[j];
    //         }else if(j < i && j%2 != 0){
    //             sumOdd = sumOdd + A[j];
    //         }else if(j > i && j%2 == 0){   //
    //             //sumEven = sumEven + A[j-1];
    //             sumOdd = sumOdd + A[j];
    //         }else if(j > i && j%2 != 0){    //-1
    //             //sumOdd = sumOdd + A[j-1];
    //             sumEven = sumEven + A[j];
    //         }

    //         if(sumEven == sumOdd && sumEven !=0){
    //             count++;
    //         }
    //     }
    // }
    //     return count;
}

