using FluentAssertions;
using NUnit.Framework;
using ProjectEuler.Problem002EvenFibonacciNumbers;
using System.Collections.Generic;

namespace ProjectEuler.UnitTest
{
    [TestFixture]
    public class Problem002EvenFibonacciNumbers
    {
        [Test]
        public void ShouldReturnFibonacciNumbersBelow10()
        {
            var fibonacciNumbers = new List<int>() { 1, 2, 3, 5, 8 };
            var fibonacciCalculator = new FibonacciCalculator();

            var fibonacciNumbersBelow10 = fibonacciCalculator.FibonacciNumbersBelow(10);

            fibonacciNumbersBelow10.Should().BeEquivalentTo(fibonacciNumbers);
        }

        [Test]
        public void ShouldReturnSumOfGivenEvenNumbers()
        {
            var numbers = new List<int>() { 1, 2, 3, 5, 8 };
            var evenNumbersSumFromList = 10;
            var mathOperations = new MathOperationsForProblem002();

            var evenNumbersSum = mathOperations.SumEvenNumbersFromAListOfNumbers(numbers);

            evenNumbersSum.Should().Be(evenNumbersSumFromList);
        }

        [Test]
        public void ShouldReturnTheSumOfEvenFibonacciNumbersBelow4MillionAsAnswerForProblem002()
        {
            var answerForTheSumOfEvenFibonacciNumbersBelow4Million = 4613732;

            var problem002Resolution = new Problem002Resolution();
            var problem002Answer = problem002Resolution.SumOfTheEvenNumbersBelow4Million();

            problem002Answer.Should().Be(answerForTheSumOfEvenFibonacciNumbersBelow4Million);
        }
    }
}
