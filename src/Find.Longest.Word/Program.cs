namespace Find.Longest.Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word = "this is some sort of sentence";
            
            var splitWord = word.Split(' ');

            var maxWord = splitWord.ToArray().MaxBy(x => x.Length);

            Console.WriteLine(maxWord);
        }
    }
}