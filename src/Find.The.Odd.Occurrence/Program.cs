namespace Find.The.Odd.Occurrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 1, 2, 3, 4, 1, 1 };

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            var len = arr.Length;

            for (int i = 0; i < len; i++)
            {
                var key = arr[i];

                if (keyValuePairs.ContainsKey(key))
                {
                    keyValuePairs[key]++;
                }
                else
                    keyValuePairs[key] = 1;
            }

            foreach (var key in keyValuePairs)
            {
                var hasRemindar = key.Value % 2 != 0;
                if (hasRemindar)
                {
                    Console.WriteLine($"The odd number in the array is: {key.Key}");
                    return;
                }
            }


        }
    }
}