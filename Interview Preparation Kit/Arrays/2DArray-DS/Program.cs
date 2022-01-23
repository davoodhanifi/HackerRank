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
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    private static readonly int[] RowPattern = { 0, 1, 2, 1, 0, 1, 2 };
    private static readonly int[] ColPattern = { 0, 0, 0, 1, 2, 2, 2 };

    public static int HourglassSum(int[][] array)
    {
        var max = int.MinValue;

        for (var i = 0; i < array.Length - 2; i++)
        {
            for (var j = 0; j < array[i].Length - 2; j++)
            {
                var sum = CalculateSum(array, i, j);
                
                if (sum > max)
                    max = sum;
            }
        }

        return max;
    }


    private static int CalculateSum(int[][] array, int i, int j)
    {
        return ColPattern.Select((t, k) => array[j + t][i + RowPattern[k]]).Sum();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        
        var array = new int[6][];

        for (var i = 0; i < 6; i++)
            array[i] = Array.ConvertAll(Console.ReadLine().TrimEnd().Split(' '), Convert.ToInt32);
        
        var result = Result.HourglassSum(array);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}