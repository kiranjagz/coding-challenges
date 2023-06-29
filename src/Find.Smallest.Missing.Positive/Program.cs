using System;
using System.Collections.Generic;

public class Solution
{
    public int FindSmallestMissingPositive(int[] A)
    {
        // Create a HashSet to store unique positive integers
        HashSet<int> set = new HashSet<int>();

        // Add positive integers to the HashSet
        foreach (int num in A)
        {
            if (num > 0)
                set.Add(num);
        }

        // Find the smallest missing positive integer
        int smallestMissing = 1;
        while (set.Contains(smallestMissing))
        {
            smallestMissing++;
        }

        return smallestMissing;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 3, 6, 4, 1, 2 };
        Solution solution = new Solution();
        int smallestMissing = solution.FindSmallestMissingPositive(arr);
        Console.WriteLine("Smallest missing positive integer: " + smallestMissing);
    }
}
