using FluentAssertions;
using NUnit.Framework;
using ProjectEuler.Problem003LargestPrimeFactor;

namespace ProjectEuler.UnitTest
{
    [TestFixture]
    public class Problem003LargestPrimeFactorTests
    {
        [Test]
        public void ShouldReturnTheLargestPrimeFactorOfTheGivenNumber()
        {
            const int numberForTest = 13195;
            const int answerForTheTestedNumber = 29;
            var mathOperations = new MathOperationsForProblem003();

            var answerLargestPrimeFactor =
                mathOperations.GetLargestPrimeFactorFromNumber(numberForTest);

            answerLargestPrimeFactor.Should().Be(answerForTheTestedNumber);
        }

        [Test]
        public void ShouldReturnTheLargestPrimeFactorOfTheNumber600851475143AsAnswerForProblem003()
        {
            const long numberForTest = 600851475143;
            const int answerForTheTestedNumber = 6857;
            var mathOperations = new MathOperationsForProblem003();

            var largestPrimeFactor =
                mathOperations.GetLargestPrimeFactorFromNumber(numberForTest);

            largestPrimeFactor.Should().Be(answerForTheTestedNumber);
        }
    }
}
