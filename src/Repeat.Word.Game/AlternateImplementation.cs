namespace ChatGPT.Game.Repeat.Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter text to be analyzed!");

                    var sentence = Console.ReadLine();

                    while (string.IsNullOrEmpty(sentence))
                    {
                        Console.WriteLine("Not a valid sentence, try again please.");
                        sentence = Console.ReadLine();
                    }

                    string[] words = sentence.ToUpper().Split(' ');

                    HashSet<string> wordSet = new HashSet<string>();
                    string? repeatedWord = null;

                    foreach (string word in words)
                    {
                        if (!wordSet.Add(word))
                        {
                            repeatedWord = word;
                            break;
                        }
                    }

                    if (repeatedWord != null)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error has occurred, error message: {ex.Message}");
                }

                Console.Read();
            }
        }
    }
}