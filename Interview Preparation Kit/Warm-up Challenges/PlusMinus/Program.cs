using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void PlusMinus(List<int> arr)
    {
        var count = (double)arr.Count;
        System.Console.WriteLine(arr.Count(x => x > 0) / count);
        System.Console.WriteLine(arr.Count(x => x < 0) / count);
        System.Console.WriteLine(arr.Count(x => x == 0) / count);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.PlusMinus(arr);
    }
}
