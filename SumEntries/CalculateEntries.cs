using System;
using System.Collections.Generic;
using System.Linq;

namespace SumEntries
{
    class CalculateEntries
    {
        public List<int> input = null;
        int expectedValue;

        /// <summary>
        /// Class Constructor
        /// </summary>
        /// <param name="expectedValue">Integer value that must be found when sum 2 or more entries</param>
        public CalculateEntries(int expectedValue)
        {
            input = Puzzle.GetPuzzleInput();
            this.expectedValue = expectedValue;

        }

        /// <summary>
        /// Find the number that summed is equal to a given integer
        /// </summary>
        /// <param name="isThreeEntries">Specify if the sum is referent of 3 numbers</param>
        /// <returns>The product of 2 or more numbers</returns>
        public int FindNumbers(bool isThreeEntries)
        {

            if (isThreeEntries)
                return this.FindNumbersThreeEntries();

            int firstNumber = 0;
            int secondNumber = 0;
            foreach (int v in this.input)
            {
                firstNumber = this.expectedValue - v;
                if (this.input.Where(x => x == (this.expectedValue - firstNumber)).FirstOrDefault() != 0)
                {
                    secondNumber = v;
                    break;
                }
            }

            return Product(new int[] { firstNumber, secondNumber });
        }

        private int FindNumbersThreeEntries()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int ThirdNumber = 0;
            foreach (int v in this.input)
            {
                firstNumber = v;
                foreach (int n in this.input.Where(x => x < v).ToList())
                {
                    secondNumber = n;
                    if (this.input.Where(x => x == (this.expectedValue - (v + n))).FirstOrDefault() != 0)
                    {
                        ThirdNumber = this.input.Where(x => x == (this.expectedValue - (v + n))).FirstOrDefault();
                        return this.Product(new int[] { firstNumber, secondNumber, ThirdNumber });
                    }
                }
            }

            return 0;

        }

        private int Product(int[] numbers)
        {
            return numbers.Aggregate(1, (x, y) => x * y);
        }
    }
}