using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t;
        string s = "";
        string evenChar = "";
        string oddChar = "";

        do
        {
            t = int.Parse(Console.ReadLine());
        } while (t < 1 || t > 10);

        for (int i = 0; i < t; i++)
        {
            s = Console.ReadLine();

            evenChar = "";
            oddChar = "";

            for (int j = 0; j < s.Length; j++)
            {
                if (j % 2 == 0) evenChar += s[j];
                if (j % 2 != 0) oddChar += s[j];
            }

            Console.WriteLine($"{evenChar} {oddChar}");
        }
    }
}