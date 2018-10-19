using FluentAssertions;
using NUnit.Framework;
using ProjectEuler.Problem001SumOfMultiplesOf3Or5;
using System.Collections.Generic;

namespace ProjectEuler.UnitTest
{
    [TestFixture]
    public class Problem001SumOfMultiplesOf3Or5
    {
        [Test]
        public void ShouldReturnTheMultiplesOfASpecifiedNumberInTheGivenPeriod()
        {
            var multiplesOf5 = new List<int>() { 5 };
            var mathOperations = new MathOperationsForProblem001();

            var multiplesOf5InTheGivenPeriod = mathOperations.GetMultiplesOfANumberInAPeriod(5, new Period(0, 9));

            multiplesOf5InTheGivenPeriod.Should().BeEquivalentTo(multiplesOf5);
        }
                
        [Test]
        public void ShouldReturnTheSumOfAListOfNumbers()
        {
            var sumAnswer = 23;
            var numbers = new List<int>() { 3, 5, 6, 9 };

            var mathOperations = new MathOperationsForProblem001();
            var sumOfAListOfNumbers = mathOperations.SumNumbersFromAList(numbers);

            sumOfAListOfNumbers.Should().Be(sumAnswer);
        }

        [Test]
        public void ShouldReturnTheSumOfMultiplesOf3Or5Below1000AsAnswerForProblem001()
        {
            var answerForTheSumOfMultiplesOf3Or5Below1000 = 233168;

            var problem001Resolution = new Problem001Resolution();
            var problem001Answer = problem001Resolution.SumOfAllTheMultiplesOf3Or5Below1000();

            problem001Answer.Should().Be(answerForTheSumOfMultiplesOf3Or5Below1000);
        }
    }
}
