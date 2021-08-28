using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first altitude: ");
            int firstAltitude = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second altitude: ");
            int secondAltitude = int.Parse(Console.ReadLine());

            Console.WriteLine("Altitude change: " + (secondAltitude - firstAltitude));
        }
    }
}
