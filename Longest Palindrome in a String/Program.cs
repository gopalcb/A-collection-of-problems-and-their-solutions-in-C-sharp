﻿// A Dynamic Programming based C# Program 
// for the Egg Dropping Puzzle 
using System;

class GFG
{

    // A utility function to get max of 
    // two integers 
    static int max(int x, int y)
    {
        return (x > y) ? x : y;
    }

    // Returns the length of the longest 
    // palindromic subsequence in seq 
    static int lps(string seq)
    {
        int n = seq.Length;
        int i, j, cl;

        // Create a table to store results 
        // of subproblems 
        int[,] L = new int[n, n];

        // Strings of length 1 are 
        // palindrome of lentgh 1 
        for (i = 0; i < n; i++)
            L[i, i] = 1;

        // Build the table. Note that the 
        // lower diagonal values of table 
        // are useless and not filled in 
        // the process. The values are 
        // filled in a manner similar to 
        // Matrix Chain Multiplication DP 
        // solution (See 
        // https:// www.geeksforgeeks.org/matrix-chain-multiplication-dp-8/ 
        // cl is length of substring 
        for (cl = 2; cl <= n; cl++)
        {
            for (i = 0; i < n - cl + 1; i++)
            {
                j = i + cl - 1;

                if (seq[i] == seq[j] && cl == 2)
                    L[i, j] = 2;
                else if (seq[i] == seq[j])
                    L[i, j] = L[i + 1, j - 1] + 2;
                else
                    L[i, j] = max(L[i, j - 1], L[i + 1, j]);
            }
        }

        return L[0, n - 1];
    }

    /* Driver program to test above  
    functions */
    public static void Main()
    {
        string seq = "GEEKS FOR GEEKS";
        int n = seq.Length;
        Console.Write("The lnegth of the "
                      + "lps is " + lps(seq));

        Console.ReadKey();
    }
}