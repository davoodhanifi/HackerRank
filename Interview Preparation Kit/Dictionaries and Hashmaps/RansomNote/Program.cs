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
     * Complete the 'checkMagazine' function below.
     *
     * The function accepts following parameters:
     *  1. STRING_ARRAY magazine
     *  2. STRING_ARRAY note
     */

    public static void CheckMagazine(string[] magazineWords, string[] noteWords)
    {
        var wordDictionary = new Dictionary<string, int>();
        foreach (var wordGroup in magazineWords.GroupBy(item => item))
        {
            wordDictionary.Add(wordGroup.Key, wordGroup.Count());
        }

        foreach (var wordGroup in noteWords.GroupBy(item => item))
        {
            if (!wordDictionary.TryGetValue(wordGroup.Key, out int count) || wordGroup.Count() > count)
            {
                Console.WriteLine("No");
                return;
            }
        }

        Console.WriteLine("Yes");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        var m = Convert.ToInt32(firstMultipleInput[0]);

        var n = Convert.ToInt32(firstMultipleInput[1]);

        string[] magazineWords = Console.ReadLine().Split(' ');

        string[] noteWords = Console.ReadLine().Split(' ');

        Result.CheckMagazine(magazineWords, noteWords);
    }
}
