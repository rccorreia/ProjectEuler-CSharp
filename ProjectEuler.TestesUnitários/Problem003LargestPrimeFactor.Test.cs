using FluentAssertions;
using ProjectEuler.Problem003LargestPrimeFactor;
using Xunit;

namespace ProjectEuler.UnitTest
{
    public class Problema003MaiorFatorPrimo
    {
        [Fact]
        public void ShouldReturnTheLargestPrimeFactorOfTheGivenNumber()
        {
            var largestPrimeFator = 29;
            var mathOperations = new MathOperationsForProblem003();

            var answerLargestPrimeFactor = mathOperations.GetLargestPrimeFactorFromNumber(13195);

            answerLargestPrimeFactor.Should().Be(largestPrimeFator);
        }

        [Fact]
        public void ShouldReturnTheLargestPrimeFactorOfTheNumber600851475143AsAnswerForProblem003()
        {
            var answerForTheLargestPrimeFactorOfTheNumber600851475143 = 6857;
            var MathOperations = new MathOperationsForProblem003();

            var largestPrimeFactor = MathOperations.GetLargestPrimeFactorFromNumber(600851475143);

            largestPrimeFactor.Should().Be(answerForTheLargestPrimeFactorOfTheNumber600851475143);
        }
    }
}
