using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    /// <summary>
    /// Exercise 8 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates rolling and using two dice
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // initialize random number generator
            RandomNumberGenerator.Initialize();

            // create two dice
            Die die1 = new Die(6);
            Die die2 = new Die(6);

            // tell the dice to roll themselves
            die1.Roll();
            die2.Roll();

            // print the top sides and the sum of the dice
            int die1TopSide = die1.TopSide;
            int die2TopSide = die2.TopSide;
            Console.WriteLine("Die1 Topside: " + die1TopSide);
            Console.WriteLine("Die2 Topside: " + die2TopSide);
            Console.WriteLine("Sum: " + (die1TopSide + die2TopSide));

            Console.WriteLine();
        }
    }
}
