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

class Solution
{

    // Complete the minimumSwaps function below.
    static int MinimumSwaps(int[] array)
    {
        var indexer = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
            indexer[array[i]-1] = i;

        var result = 0;
        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] != i + 1)
            {
                var temp = array[i];
                array[i] = i + 1;
                array[indexer[i]] = temp;
                indexer[temp - 1] = indexer[i];
                indexer[i] = i;
                result++;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        var array = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int result = MinimumSwaps(array);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
