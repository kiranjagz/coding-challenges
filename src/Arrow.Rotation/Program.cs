using System;

public class Program
{
    public static void Main()
    {
        string S = "^vv<v";
        int minArrowsToRotate = MinArrowsToRotate(S);
        Console.WriteLine("Minimum number of arrows to rotate: " + minArrowsToRotate);
    }

    public static int MinArrowsToRotate(string S)
    {
        int upCount = 0;
        int downCount = 0;
        int leftCount = 0;
        int rightCount = 0;

        // Step 1: Count the occurrences of each arrow direction in the input string
        foreach (char arrow in S)
        {
            switch (arrow)
            {
                case '^':
                    upCount++;
                    break;
                case 'v':
                    downCount++;
                    break;
                case '<':
                    leftCount++;
                    break;
                case '>':
                    rightCount++;
                    break;
                default:
                    break;
            }
        }

        // Step 2: Find the maximum count among all arrow directions
        int totalCount = S.Length;
        int maxCount = Math.Max(Math.Max(upCount, downCount), Math.Max(leftCount, rightCount));

        // Step 3: Calculate the minimum number of arrows to rotate
        int minArrowsToRotate = totalCount - maxCount;

        // Step 4: Return the result
        return minArrowsToRotate;
    }
}
