using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'maximumToys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY prices
     *  2. INTEGER k
     */

    public static int MaximumToys(List<int> prices, int amount)
    {
        var count = 0;
        var sum = 0;
        prices.Sort();

        foreach (var item in prices)
        {
            if (sum + item <= amount)
            {
                sum += item;
                count++;
            }
        }
        
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        var n = Convert.ToInt32(firstMultipleInput[0]);
        var amount = Convert.ToInt32(firstMultipleInput[1]);
        var prices = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pricesTemp => Convert.ToInt32(pricesTemp)).ToList();
        var result = Result.MaximumToys(prices, amount);

        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
