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
     * Complete the 'countSwaps' function below.
     *
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static void CountSwaps(int[] array, int size)
    {
        var countSwaps = 0;

        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size - 1; j++)
            {
                if (array[j] > array[j+1])
                {
                    var temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                    countSwaps++;
                }
            }
        }

        Console.WriteLine($"Array is sorted in {countSwaps} swaps.");
        Console.WriteLine($"First Element: {array[0]}");
        Console.WriteLine($"Last Element: {array[size - 1]}");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        var size = Convert.ToInt32(Console.ReadLine().Trim());
        var array = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToArray();

        Result.CountSwaps(array, size);
    }
}
