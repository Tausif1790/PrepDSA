//You will be given an integer n. You need to return the count of prime numbers less than or equal to n.

class Solution
{
    public int solve(int A)
    {
        int count = 0;
        for (int i = 2; i <= A; i++)
        {
            if (isprime(i) == true)
            {
                count++;
            }
        }
        return count;
    }

    bool isprime(int a)
    {
            return true;
        if (a == 2)
        {
        }
        for (int i = 2; i < a; i++)
        {
            if (a % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
