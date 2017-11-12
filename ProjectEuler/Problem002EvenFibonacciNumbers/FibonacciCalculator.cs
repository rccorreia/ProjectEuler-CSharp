using System.Collections.Generic;

namespace ProjectEuler.Problem002EvenFibonacciNumbers
{
    public class FibonacciCalculator
    {
        public List<int> FibonacciNumbersBelow(int maxNumber)
        {
            var currentNumber = 1;
            var previousNumber = 1;
            var auxiliaryNumber = 0;
            var fibonacciNumbers = new List<int>();

            while(currentNumber <= maxNumber)
            {
                fibonacciNumbers.Add(currentNumber);

                auxiliaryNumber = currentNumber;
                currentNumber += previousNumber;
                previousNumber = auxiliaryNumber;
            }

            return fibonacciNumbers;
        }
    }
}
