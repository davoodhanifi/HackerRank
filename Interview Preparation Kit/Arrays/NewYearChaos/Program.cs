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
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    public static void MinimumBribes(int[] array)
    {
        var result = 0;

        for (var i = 0; i < array.Length; i++)
        {
            var item = array[i];

            if (item > i + 3)
            {
                Console.WriteLine("Too chaotic");
                return;
            }

            for (var j = Math.Max(0, item - 2); j < i; j++)
            {
                if (array[j] > item)
                    result++;
            }
        }

        Console.WriteLine(result);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            var array = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            Result.MinimumBribes(array);
        }
    }
}
