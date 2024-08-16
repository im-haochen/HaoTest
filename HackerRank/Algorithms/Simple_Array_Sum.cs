#region Exam questions
// Given an array of integers, find the sum of its elements.

// For example, if the array `ar = [1, 2, 3]`, 1 + 2 + 3 = 6, so return 6.

// **Function Description**

// Complete the simpleArraySum function in the editor below. It must return the sum of the array elements as an integer.  
// `simpleArraySum` has the following parameter(s):  
// - `ar`: an array of integers

// **Input Format**

// The first line contains an integer, `n`, denoting the size of the array.  
// The second line contains `n` space-separated integers representing the array's elements.

// **Constraints**

// 0 < n, `ar[i]` ≤ 1000

// **Output Format**

// Print the sum of the array's elements as a single integer.

// **Sample Input**

// 6  
// 1 2 3 4 10 11

// **Sample Output**

// 31

// **Explanation**

// We print the sum of the array's elements: 1 + 2 + 3 + 4 + 10 + 11 = 31.
#endregion Exam questions

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
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int simpleArraySum(List<int> ar)
    {
        int sum = 0;
        for(int i = 0; i <ar.Count; i++){
            sum += ar[i];
        }
        return sum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
