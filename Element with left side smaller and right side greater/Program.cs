using System;

class GFG
{
    static int findElement(int[] arr, int n)
    {
        // leftMax[i] stores maximum of arr[0..i-1] 
        int[] leftMax = new int[n];
        leftMax[0] = int.MinValue;

        // Fill leftMax[]1..n-1] 
        for (int i = 1; i < n; i++)
            leftMax[i] = Math.Max(leftMax[i - 1], arr[i - 1]);

        // Initialize minimum from right 
        int rightMin = int.MaxValue;

        // Traverse array from right 
        for (int i = n - 1; i >= 0; i--)
        {
            // Check if we found a required element 
            if (leftMax[i] < arr[i] && rightMin > arr[i])
                return i;

            // Update right minimum 
            rightMin = Math.Min(rightMin, arr[i]);
        }

        // If there was no element matching criteria 
        return -1;
    }

    // Driver program 
    public static void Main()
    {
        int[] arr = { 5, 1, 4, 3, 6, 8, 10, 7, 9 };
        int n = arr.Length;
        Console.Write("Index of the element is " + findElement(arr, n));
        Console.ReadKey();
    }
}