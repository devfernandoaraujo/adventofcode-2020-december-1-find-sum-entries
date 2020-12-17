using System;
using System.Collections.Generic;
using System.Linq;

namespace SumEntries
{
    class CalculateEntries
    {
        public List<int> input = null;
        int expectedValue;
        int remainder;
        int number;
        int numOfIterations;
        public CalculateEntries(int expectedValue, int numOfIterations)
        {
            input = Puzzle.GetPuzzleInput();
            this.expectedValue = expectedValue;
            this.remainder = 0;
            this.number = 0;
            this.numOfIterations = numOfIterations;
        }

        public void FindNumbers()
        {

            foreach (int v in this.input)
            {
                this.remainder = this.expectedValue - v;
                if (this.input.Where(x => x == remainder).FirstOrDefault() != 0)
                {
                    this.number = v;
                    break;
                }
            }
        }

        public void FindNumbers(List<int> list, int iteration = 1)
        {
            if (iteration > this.numOfIterations)
                return;

            foreach (int v in list)
            {
                this.remainder = this.expectedValue - v;
                if (this.input.Where(x => x == remainder).FirstOrDefault() != 0)
                {
                    this.number = v;
                    break;
                }
            }
        }

        public int MultiplyValues()
        {
            return this.number * this.remainder;
        }
    }
}