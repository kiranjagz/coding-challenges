using System;
using System.Collections.Generic;

namespace Matching.Brackets
{
    class BracketMatcher
    {
        static void Main()
        {
            //string input = "(c([od]er)) b(yt[e])";
            string input = "(())";

            int matchingPairsCount = CountMatchingBrackets(input);

            Console.WriteLine("Number of matching bracket pairs: " + matchingPairsCount);
        }

        static int CountMatchingBrackets(string input)
        {
            Stack<char> stack = new Stack<char>();
            int matchingPairsCount = 0;

            foreach (char c in input)
            {
                if (IsOpeningBracket(c))
                {
                    stack.Push(c);
                }
                else if (IsClosingBracket(c))
                {
                    if (stack.Count > 0 && IsMatchingPair(stack.Peek(), c))
                    {
                        stack.Pop();
                        matchingPairsCount++;
                    }
                }
            }

            return matchingPairsCount;
        }

        static bool IsOpeningBracket(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        static bool IsClosingBracket(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }

        static bool IsMatchingPair(char openingBracket, char closingBracket)
        {
            return openingBracket == '(' && closingBracket == ')'
                || openingBracket == '[' && closingBracket == ']'
                || openingBracket == '{' && closingBracket == '}';
        }
    }
}