namespace Heap.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hasValue = new HasValue();
            hasValue.Value = 1;
            var hash = hasValue.GetHashCode();
            Console.WriteLine(hash);
            Console.WriteLine(hasValue.Value);

            hasValue.Value = 2;
            ChangeValue(hasValue);

            Console.WriteLine(hasValue.Value);
            Console.ReadLine();
        }

        public static void ChangeValue(HasValue hasValue)
        {
            var hash = hasValue.GetHashCode();
            Console.WriteLine(hash);

            hasValue = new HasValue();

            hasValue.Value = 3;
            var hash1 = hasValue.GetHashCode();
            Console.WriteLine(hash1);
            Console.WriteLine(hasValue.Value);
        }

        public class HasValue
        {
            public int Value;
        }
    }
}