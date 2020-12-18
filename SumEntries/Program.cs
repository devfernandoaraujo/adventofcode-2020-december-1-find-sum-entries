using System;

namespace SumEntries
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateEntries _calculateEntries = new CalculateEntries(2020);
            _calculateEntries.FindNumbers(false);

            Console.WriteLine("The multiplycation of the 2 numbers is: {0}", _calculateEntries.FindNumbers(false));
            Console.WriteLine("The multiplycation of the 3 numbers is: {0}", _calculateEntries.FindNumbers(true));

            Console.ReadKey();
        }
    }
}
