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
     * Complete the 'arrayManipulation' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static long ArrayManipulation(int n, int[][] queries)
    {
        var array = new long[n];
        long max = 0;
        long sum = 0;

        for (var i = 0; i < queries.Length; i++)
        {
            var a = queries[i][0]- 1;
            var b = queries[i][1];
            var k = queries[i][2];

            array[a] += k;

            if (b < n)
                array[b] -= k;
        }

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (sum > max)
                max = sum;
        }

        return max;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);
        var queries = new int[m][];

        for (int i = 0; i < m; i++)
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        var result = Result.ArrayManipulation(n, queries);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
