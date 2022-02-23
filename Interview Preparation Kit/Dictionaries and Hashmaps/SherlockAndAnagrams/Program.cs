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

    // Complete the sherlockAndAnagrams function below.
    public static int SherlockAndAnagrams(string targetString)
    {
        var dictionary = new Dictionary<string, int>();

        for (var len = 1; len < targetString.Length; len++)
        {
            for (int index = 0; index <= targetString.Length - len; index++)
            {
                var subString = targetString.Substring(index, len);
                var stringBuilder = new StringBuilder(subString.Length);

                foreach (var character in subString.ToCharArray().OrderBy(item => item))
                    stringBuilder.Append(character);

                var key = stringBuilder.ToString();

                if (dictionary.ContainsKey(key))
                    dictionary[key]++;
                else
                    dictionary[key] = 1;
            }
        }

        return dictionary.Where(item => item.Value > 1).Sum(item => item.Value * (item.Value - 1) / 2);
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            var targetString = Console.ReadLine();
            var result = SherlockAndAnagrams(targetString);
            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
