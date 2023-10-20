You are given a character string A having length N, consisting of only lowercase and uppercase latin letters.
You have to toggle case of each character of string A. For e.g 'A' is changed to 'a', 'e' is changed to 'E', etc.

//----------------------------------------------//
class Solution
{
    public string solve(string A)
    {
        int n = A.Length;
        char[] result = new char[n];

        for (int i = 0; i < n; i++)
        {
            char ch = A[i];
            if (ch >= 'A' && ch <= 'Z')
            {
                result[i] = (char)(ch + 32);            // ch + 32 resulting int value, so needs to convert to char
            }
            else
            {
                result[i] = (char)(ch - 32);
            }
        }

        return new string(result);                    // "new" required when converting char[] to string
    }
}
