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
     * Complete the 'makeAnagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING a
     *  2. STRING b
     */

    public static int MakeAnagram(string first, string second)
    {
        var result = 0;
        var firstDictionary = MakeDictionary(first);
        var secondDictionary = MakeDictionary(second);

        foreach (var item in firstDictionary)
        {
            if (secondDictionary.TryGetValue(item.Key, out var value))
                result += Math.Abs(value - item.Value);
            else
                result += item.Value;
            
        }

        foreach (var item in secondDictionary)
        {
            if (!firstDictionary.TryGetValue(item.Key, out var value))
                result += item.Value;
            
        }

        return result;
    }

    public static Dictionary<char, int> MakeDictionary(string str)
    {
        var dictionary = new Dictionary<char, int>();
        foreach (char c in str)
        {
            if (!dictionary.TryGetValue(c, out var value))
            {
                dictionary.Add(c, 1);
            }
            else
            {
                dictionary[c] = value + 1;
            }
        }

        return dictionary;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var first = Console.ReadLine();
        var second = Console.ReadLine();
        var result = Result.MakeAnagram(first, second);

        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
