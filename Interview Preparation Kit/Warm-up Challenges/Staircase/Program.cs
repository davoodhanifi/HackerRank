using System;

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void Staircase(int n)
    {
        for (int i = 1; i<= n; i++)
        {
            for (int j = i; j<n; j++)
                Console.Write(" ");

            for (int k = i; k>0; k--)
                Console.Write("#");

            Console.WriteLine();
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.Staircase(n);
    }
}
