Given two binary strings A and B. Return their sum (also a binary string).
Problem Constraints
1 <= length of A <= 105
1 <= length of B <= 105
A and B are binary strings

Input Format: The two argument A and B are binary strings.

Output Format: Return a binary string denoting the sum of A and B

Example Input
Input 1:
A = "100"
B = "11"
Input 2:
A = "110"
B = "10"

Example Output
Output 1: "111"
Output 2: "1000"

//-------------------------------------------------------------------//

class Solution
{
    public string addBinary(string A, string B)
    {

        string AA = "";
        string BB = "";

        if (A.Length > B.Length)
        {
            // Pad BB with leading zeros to match the length of A
            BB = B.PadLeft(A.Length, '0');
            AA = A;
        }
        else if (A.Length < B.Length)
        {
            // Pad AA with leading zeros to match the length of B
            AA = A.PadLeft(B.Length, '0');
            BB = B;
        }
        else
        {
            // If both strings are of the same length, no padding is needed
            AA = A;
            BB = B;
        }

        string result3 = "";
        int n = AA.Length;
        int temp = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            int res = (AA[i] - '0') + (BB[i] - '0') + temp;
            temp = 0;

            if (res == 0)
            {
                result3 = "0" + result3;
            }
            else if (res == 1)
            {
                result3 = "1" + result3;
            }
            else if (res == 2)
            {
                result3 = "0" + result3;
                temp = 1;
            }
            else if (res == 3)
            {
                result3 = "1" + result3;
                temp = 1;
            }
        }

        // If there's a carry after the loop, add it to the result
        if (temp == 1)
        {
            result3 = "1" + result3;
        }

        return result3;
    }
}


// above Exceeded time limit, below chat GPT method

using System.Text;

class Solution
{
    public string addBinary(string A, string B)
    {
        StringBuilder result = new StringBuilder();
        int carry = 0;
        int i = A.Length - 1, j = B.Length - 1;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;
            if (i >= 0) sum += A[i] - '0';
            if (j >= 0) sum += B[j] - '0';

            result.Insert(0, (sum % 2).ToString());
            carry = sum / 2;

            i--; j--;
        }

        return result.ToString();
    }
}

