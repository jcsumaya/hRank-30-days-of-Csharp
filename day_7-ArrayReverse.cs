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
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        // arr.Reverse(); using Reverse method

        ReverseList(arr);
        Console.WriteLine(String.Join(" ", arr));
    }

    public static void ReverseList(List<int> list)
    {
        int start = 0;
        int end = list.Count - 1;

        while (start < end)
        {
            // Swap elements at start and end indices
            int temp = list[start];
            list[start] = list[end];
            list[end] = temp;

            // Move indices towards the center
            start++;
            end--;
        }
    }
}