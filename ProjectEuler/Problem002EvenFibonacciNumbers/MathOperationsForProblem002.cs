using ProjectEuler.Shared;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problem002EvenFibonacciNumbers
{
    public class MathOperationsForProblem002
    {
        public int SumEvenNumbersFromAListOfNumbers(List<int> numbers)
        {
            return numbers.Where(number => SharedMathOperations.IsEvenNumber(number)).Sum();
        }
    }
}
