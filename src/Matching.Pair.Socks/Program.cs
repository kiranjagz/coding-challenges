namespace Matching.Pair.Socks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] socks = { "red", "green", "red", "blue", "blue", "red", "red" };

            Dictionary<string, int> sockCounts = new Dictionary<string, int>();

            foreach (string sock in socks)
            {
                if (sockCounts.ContainsKey(sock))
                {
                    var tryGetValue = sockCounts.TryGetValue(sock, out int count);

                    if (tryGetValue)
                    {
                        sockCounts[sock] = count + 1;
                    }

                    //sockCounts[sock]++;
                }
                else
                {
                    sockCounts[sock] = 1;
                }
            }

            var total = 0;

            foreach (var kvp in sockCounts)
            {
                var pairs = kvp.Value / 2;

                total += pairs;

                Console.WriteLine($"{kvp.Key.ToUpper()} has a total of pairs: {pairs}");
            }

            Console.WriteLine("Total number of pairs: " + total);

            Console.ReadLine();
        }
    }
}