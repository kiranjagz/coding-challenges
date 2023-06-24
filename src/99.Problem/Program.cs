using System.ComponentModel.DataAnnotations;

namespace _99.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal number = 249;

            var closestMultiple = RoundToTheNearestHundred(number);

            if (closestMultiple < number)
                closestMultiple += 99;
            else
                closestMultiple--;

            Console.WriteLine(closestMultiple);
        }

        private static decimal RoundToTheNearestHundred(decimal value) => Math.Round(value / 100) * 100;
    }
}