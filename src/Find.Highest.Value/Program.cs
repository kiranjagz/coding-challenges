using System;

class Program
{
    static void Main()
    {
        int[] testCases = { 19585, -5859, -5000 };
        var solution = new Solution();

        foreach (var testCase in testCases)
        {
            var result = solution.solution(testCase);

            Console.WriteLine(result);
        }
    }

    class Solution
    {
        public int solution(int N)
        {
            var convertNumber = N.ToString();
            var index = convertNumber.LastIndexOf('5');

            var updatedNumber = convertNumber.Remove(index, 1);

            var intNumber = int.Parse(updatedNumber);

            if (int.Parse(convertNumber) < 0)
            {
                return intNumber;
            }
            else
            {
                var result = int.Parse(convertNumber) < 0 ? -intNumber : intNumber;
                return result;
            }
        }
    }

}
