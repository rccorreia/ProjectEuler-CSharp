using ProjectEuler.Shared;
using System;

namespace ProjectEuler.Problem003LargestPrimeFactor
{
    public class MathOperationsForProblem003
    {
        public long GetLargestPrimeFactorFromNumber(long number)
        {
            if (SharedMathOperations.IsEvenNumber(number))
                return GetLargestPrimeFactorFromEvenNumber(number);
            else
                return GetLargestPrimeFactorFromOddNumber(number);
        }

        private long GetLargestPrimeFactorFromEvenNumber(long number)
        {
            while (SharedMathOperations.IsEvenNumber(number))
                number = number / 2;

            return number;
        }

        private long GetLargestPrimeFactorFromOddNumber(long oddNumber)
        {
            if (oddNumber <= 1) return 0;
            long lastFactor = 0;
            long factor = 3;

            long auxiliaryNumber = oddNumber;
            var maxFactor = MaxPrimeFactorOfGivenNumber(auxiliaryNumber);

            while (auxiliaryNumber > 1 && factor <= maxFactor)
            {
                if (IsFactorDivisorOfNumber(factor, auxiliaryNumber))
                {
                    auxiliaryNumber = auxiliaryNumber / factor;
                    lastFactor = factor;
                    while (IsFactorDivisorOfNumber(factor, auxiliaryNumber))
                        auxiliaryNumber = auxiliaryNumber / factor;

                    maxFactor = MaxPrimeFactorOfGivenNumber(auxiliaryNumber);
                }

                factor = NextEvenNumber(factor);
            }
            return auxiliaryNumber;
        }

        private double MaxPrimeFactorOfGivenNumber(long number)
        {
            return Math.Sqrt(number);
        }

        private long NextEvenNumber(long number)
        {
            return number + 2;
        }

        private bool IsFactorDivisorOfNumber(long factor, long number)
        {
            return number % factor == 0;
        }
    }
}
