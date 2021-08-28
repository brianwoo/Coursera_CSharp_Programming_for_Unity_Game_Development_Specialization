using System;

namespace Exercise6
{
    class Program
    {

        static float toRadians(float degrees) {
            return degrees * (float) Math.PI / 180;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an angle of degrees: ");
            float degrees = int.Parse(Console.ReadLine());
            float radians = toRadians(degrees);

            float cosine = (float) Math.Cos(radians);
            float sine = (float) Math.Sin(radians);

            Console.WriteLine("Cos: " + cosine + " Sine: " + sine);
        }
    }
}
