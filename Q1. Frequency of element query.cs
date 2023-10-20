Given an array A. You have some integers given in the array B.
For the i-th number, find the frequency of B[i] in the array A 
and return a list containing all the frequencies.

Input Format:
First argument A is an array of integers.
Second argument B is an array of integers denoting the queries.

Output Format:
Return an array of integers containing frequency of the each element in B.

Example Input
Input 1:
A = [1, 2, 1, 1]
B = [1, 2]
Input 2:
A = [2, 5, 9, 2, 8]
B = [3, 2]

Example Output
Output 1:
[3, 1]
Output 2:
[0, 2]

//-----------------------------------------------//

class Solution
{
    public List<int> solve(List<int> A, List<int> B)
    {

        List<int> ans = new List<int>();
        Dictionary<int, int> dis = new Dictionary<int, int>();

        // Store all element in Dictionary
        foreach (int el in A)
        {
            if (dis.ContainsKey(el))
            {
                int freq = dis[el];    // value at Key
                dis[el] = freq + 1;    // dis.Add(el, freq + 1);    //error because we adding key and its value but key is already present
            }
            else
            {
                dis[el] = 1;            //even if key is not present, it will add with value 1
            }
        }

        foreach (int el in B)
        {
            if (dis.ContainsKey(el))
            {
                ans.Add(dis[el]);
            }
            else
            {
                ans.Add(0);
            }
        }

        return ans;


        //-----Brute Force------------//
        // List<int> ans = new List<int>();
        // int n = A.Count;
        // int m = B.Count;

        // for(int i=0; i<m; i++){
        //     int el = B[i];
        //     int count = 0;

        //     for(int j=0; j<n; j++){
        //         if(A[j] == el){
        //             count++;
        //         }
        //     }

        //     ans.Add(count);
        // }

        // return ans;
    }
}

TC = O(n+q);   ~O(n);
SC = O(n)
