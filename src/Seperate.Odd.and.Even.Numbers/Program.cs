namespace Seperate.Odd.and.Even.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7 };
            int[] even = new int[10];
            int[] odd = new int[10];

            int oddCount = 0;
            int evenCount = 0;

            for (int i = 0; i < values.Length; i++)
            {
                var value = values[i];

                if (value % 2 == 0)
                {
                    even[evenCount] = value;
                    evenCount++;
                }
                else
                {
                    odd[oddCount] = value;
                    oddCount++;
                }

                Console.WriteLine(values[i]);
            }
            
            for(int i = 0;i < evenCount; i++)
            {
                Console.WriteLine("The even numbers are: " + even[i]);
            }

            for (int i = 0; i < oddCount; i++)
            {
                Console.WriteLine("The odd numbers are: " + odd[i]);
            }
        }
    }
}