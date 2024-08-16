#region 題目
// Complete the function solveMeFirst to compute the sum of two integers.

// Example
// a = 7
// b = 3
// Return 10.

// Function Description
// Complete the solveMeFirst function in the editor below.

// solveMeFirst has the following parameters:
// - int a: the first value
// - int b: the second value

// Returns
// - int: the sum of a and b

// Constraints
// 1 ≤ a, b ≤ 1000
#endregion 題目

using System;
using System.Collections.Generic;
using System.IO;
class Solution {

    static int solveMeFirst(int a, int b) { 
      // Hint: Type return a+b; below  
      return a + b;
    }

    static void Main(String[] args) {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(val1,val2);
        Console.WriteLine(sum);
    }
}      