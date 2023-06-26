namespace Bubble.Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 9};

            // Bubble sort
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Swap elements
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}