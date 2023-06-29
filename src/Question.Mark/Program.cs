using System;

public class Solution
{
    public bool QuestionsMarks(string str)
    {
        // Variable to track the current sum of numbers
        int currentSum = 0;

        // Variable to track if a pair with the correct number of question marks has been found
        bool pairFound = false;

        // Variables to track the positions of the numbers in the pair
        int firstNumPos = -1;
        int secondNumPos = -1;

        // Iterate through the string
        for (int i = 0; i < str.Length; i++)
        {
            char currentChar = str[i];

            // Check if the character is a digit
            if (Char.IsDigit(currentChar))
            {
                int num1 = currentChar - '0';

                // Check if a pair has already been found
                if (pairFound)
                {
                    // If a second number is found, update the second number position
                    secondNumPos = i;

                    // Calculate the sum of the two numbers
                    int num2 = str[secondNumPos] - '0';
                    int sum = num1 + num2;

                    // Check if the sum is 10 and the number of question marks between the pair is exactly 3
                    if (sum == 10 && CountQuestionMarks(str, firstNumPos, secondNumPos) == 3)
                        return true;

                    // Reset the variables for the next potential pair
                    firstNumPos = secondNumPos;
                    currentSum = num2;
                }
                else
                {
                    // Update the first number position and the current sum
                    firstNumPos = i;
                    currentSum = num1;
                }

                pairFound = false;
            }
            // Check if the character is a question mark
            else if (currentChar == '?')
            {
                // Check if a first number has been found
                if (firstNumPos != -1)
                {
                    // Check if there are question marks between the numbers
                    int qmCount = CountQuestionMarks(str, firstNumPos, i);
                    if (qmCount >= 1)
                        pairFound = true;
                }
            }
        }

        return false;
    }

    // Helper function to count the number of question marks between two positions in the string
    private int CountQuestionMarks(string str, int startPos, int endPos)
    {
        int count = 0;
        for (int i = startPos + 1; i < endPos; i++)
        {
            if (str[i] == '?')
                count++;
        }
        return count;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string inputString = "acc?7??sss?3rr1??????5";
        Solution solution = new Solution();
        bool hasCorrectQuestionMarks = solution.QuestionsMarks(inputString);
        Console.WriteLine("Has correct question marks: " + hasCorrectQuestionMarks);
    }
}
