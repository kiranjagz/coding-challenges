using System;

namespace Find.Valid.Gas.Station
{
    internal class Program
    {
        public static string GetGasStation(string[] strArr)
        {
            int numStations = Convert.ToInt32(strArr[0]);
            int gasNeeded = 0;
            int distanceToNext = 0;
            int startingStation = -1;

            // Loop through each gas station
            for (int i = 1; i < numStations; i++)
            {
                string[] stationInfo = strArr[i].Split(':');
                gasNeeded += Convert.ToInt32(stationInfo[0]);
                distanceToNext = Convert.ToInt32(stationInfo[1]);

                // If gas needed is greater than distance to next station, update the starting station
                if (gasNeeded >= distanceToNext)
                {
                    gasNeeded -= distanceToNext;
                    startingStation = i;
                }
                else
                {
                    // Reset gas needed and starting station if gas needed is not enough
                    gasNeeded = 0;
                    startingStation = -1;
                }
            }

            // Check if there's a valid starting station
            if (startingStation != -1)
            {
                return strArr[startingStation].Split(':')[2];
            }
            else
            {
                return "impossible";
            }
        }

        static void Main()
        {
            // Example test cases
            string[] test1 = { "4", "1:1:2", "2:2:2", "1:2:2", "0:1:1" };
            Console.WriteLine(GetGasStation(test1)); // Output: 2

            string[] test2 = { "3", "2:3:1", "2:2:2", "1:1:2" };
            Console.WriteLine(GetGasStation(test2)); // Output: impossible
        }
    }
}