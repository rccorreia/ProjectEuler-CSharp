namespace ProjectEuler.Problem002EvenFibonacciNumbers
{
    public class Problem002Resolution
    {
        public int SumOfTheEvenNumbersBelow4Million()
        {
            var fibonacciCalculator = new FibonacciCalculator();
            var mathOperations = new MathOperationsForProblem002();

            var fibonacciNumbersBelow4Million = fibonacciCalculator.FibonacciNumbersBelow(4000000);

            return mathOperations.SumEvenNumbersFromAListOfNumbers(fibonacciNumbersBelow4Million);
        }
    }
}
