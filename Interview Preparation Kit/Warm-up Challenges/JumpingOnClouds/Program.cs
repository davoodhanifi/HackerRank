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
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int JumpingOnClouds(int[] c)
    {
        const int maxJump = 2;
        var jumpCount = 0;
        var i = 0;
        var arrayLengh = c.Length;
        var noMoreJump = false;

        while (i < arrayLengh && !noMoreJump)
        {
            noMoreJump = true;

            for (var j = maxJump; j > 0; j--)
            {
                if (i + j < arrayLengh && c[i + j] == 0)
                {
                    noMoreJump = false;
                    jumpCount++;
                    i += j;
                    break;
                }
            }
        }

        return jumpCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var n = Convert.ToInt32(Console.ReadLine().Trim());

        var c = Array.ConvertAll(Console.ReadLine().TrimEnd().Split(' '), cTemp => Convert.ToInt32(cTemp));

        var result = Result.JumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
