using System;

namespace IntegerDataTypes
{
    /// <summary>
    /// Integer Data Types lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demo integer data types
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int totalSecondsPlayed = 100;
            const int SecondsPerMinute = 60;

            // calculate mins and secs played
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;
            // print results
            Console.WriteLine("Minutes Played: " + minutesPlayed);
            Console.WriteLine("Seconds Played: " + secondsPlayed);

            Console.WriteLine();
        }
    }
}
