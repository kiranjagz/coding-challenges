namespace EvenSumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 8, 11, 14 };

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
                else
                    oddSum = oddSum + numbers[i];
            }

            Console.WriteLine("Even sum: " + evenSum);

            Console.WriteLine("Odd sum: " + oddSum);
        }
    }
}