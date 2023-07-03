using System;

class Program
{
    static int MinimumSwitchesToTurnOnBulbs(int[] bulbs)
    {
        int count = 0; // Count of switches pressed
        int maxIndex = 0; // Maximum index encountered while iterating

        for (int i = 0; i < bulbs.Length; i++)
        {
            var bulb = bulbs[i];
            maxIndex = Math.Max(maxIndex, bulb);
            var currentIndex = i + 1;

            // If the current index equals the maximum index encountered so far,
            // it means all previous bulbs are turned on
            if (maxIndex == currentIndex)
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        int[] bulbs = { 2, 1, 3, 5, 4 };
        int minSwitches = MinimumSwitchesToTurnOnBulbs(bulbs);

        Console.WriteLine("Minimum number of switches required: " + minSwitches);
    }
}
