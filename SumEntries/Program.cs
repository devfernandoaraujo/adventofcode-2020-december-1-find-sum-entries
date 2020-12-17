using System;

namespace SumEntries
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateEntries _calculateEntries = new CalculateEntries(2020);
            _calculateEntries.FindNumbers();

            Console.WriteLine("The number is: {0}", _calculateEntries.MultiplyValues());

            Console.ReadKey();
        }
    }
}
