using System;

public class Program
{
    public static bool CheckOccurrences(string input)
    {
        bool foundB = false;

        foreach (char c in input)
        {
            if (c == 'a')
            {
                if (foundB)
                    return false; // If 'a' occurs after 'b', return false
            }
            else if (c == 'b')
            {
                foundB = true;
            }
        }

        return true; // If all occurrences of 'a' are before 'b', return true
    }

    public static void Main(string[] args)
    {
        string input = "abbabbaaabb"; // Replace this with your input string
        bool result = CheckOccurrences(input);
        Console.WriteLine(result);
    }
}
