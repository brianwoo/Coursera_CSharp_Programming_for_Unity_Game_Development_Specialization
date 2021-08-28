using System;

namespace FloatingPointDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 1360;
            int totalSecondPlayed = 10000;

            float pointsPerSecond = (float)score / totalSecondPlayed;

            // calc and print points per second
            Console.WriteLine("Points per Sec: " + pointsPerSecond);
        }
    }
}
