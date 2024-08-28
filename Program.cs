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
     * Complete the 'findMedian' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int findMedian(List<int> arr)
    {
        arr.Sort();
        int mid = arr.Count / 2;
        int median = 0;
        if (mid % 2 != 0)
        {
            median = arr[mid];
        }
        else
        {
            median = (arr[mid +1] + arr[mid]) / 2;
        }

        return median;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Find the Median Value");
        Console.WriteLine("Enter the N value");
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Console.WriteLine("Enter the Values to find the Median");
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.findMedian(arr);
        Console.WriteLine(result);        
    }
}