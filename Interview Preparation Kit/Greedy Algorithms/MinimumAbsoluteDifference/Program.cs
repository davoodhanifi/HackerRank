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
     * Complete the 'minimumAbsoluteDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int MinimumAbsoluteDifference(int[] array)
    {
        Array.Sort(array);
        int result = int.MaxValue;
        for (int i = 1; i < array.Length; i++)
        {
            var diff = Math.Abs(array[i] - array[i - 1]);

            if (diff == 0)
                return 0;

            result = Math.Min(result, diff);
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var n = Convert.ToInt32(Console.ReadLine().Trim());

        var array = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        var result = Result.MinimumAbsoluteDifference(array);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
