using FluentAssertions;
using NUnit.Framework;
using ProjectEuler.Problem003LargestPrimeFactor;

namespace ProjectEuler.UnitTest
{
    [TestFixture]
    public class Problema003MaiorFatorPrimo
    {
        [Test]
        public void ShouldReturnTheLargestPrimeFactorOfTheGivenNumber()
        {
            var largestPrimeFator = 29;
            var mathOperations = new MathOperationsForProblem003();

            var answerLargestPrimeFactor = mathOperations.GetLargestPrimeFactorFromNumber(13195);

            answerLargestPrimeFactor.Should().Be(largestPrimeFator);
        }

        [Test]
        public void ShouldReturnTheLargestPrimeFactorOfTheNumber600851475143AsAnswerForProblem003()
        {
            var answerForTheLargestPrimeFactorOfTheNumber600851475143 = 6857;
            var MathOperations = new MathOperationsForProblem003();

            var largestPrimeFactor = MathOperations.GetLargestPrimeFactorFromNumber(600851475143);

            largestPrimeFactor.Should().Be(answerForTheLargestPrimeFactorOfTheNumber600851475143);
        }
    }
}
