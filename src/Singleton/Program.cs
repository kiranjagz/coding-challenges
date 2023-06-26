namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = Singleton.GetInstance();

            obj.SomeMethod();
        }

        public class Singleton
        {
            private static Singleton instance;

            // Private constructor to prevent direct instantiation
            private Singleton()
            {
                // Initialization code, if needed
            }

            // Public static method to access the singleton instance
            public static Singleton GetInstance()
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }

            // Other methods and properties of the singleton class
            public void SomeMethod()
            {
                // Method implementation
                Console.WriteLine("Hello");
            }
        }
    }
}