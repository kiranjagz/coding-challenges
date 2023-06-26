namespace Count.Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {1,1,3,4,5,6,3,3,4,5};

            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dictionary.ContainsKey(numbers[i]))
                {
                    dictionary[numbers[i]] = 1;
                }
                else
                {
                    dictionary[numbers[i]]++;
                }
            }

            var max = dictionary.Max(x => x.Value);

            Console.WriteLine(max.ToString());  
        }
    }
}