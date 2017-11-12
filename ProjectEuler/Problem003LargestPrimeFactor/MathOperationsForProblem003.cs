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

        private long GetLargestPrimeFactorFromEvenNumber(long evenNumber)
        {
            long auxiliaryNumber = evenNumber / 2;
            long largestPrimeFactor;

            while (SharedMathOperations.IsEvenNumber(auxiliaryNumber))
                auxiliaryNumber = auxiliaryNumber / 2;

            largestPrimeFactor = auxiliaryNumber;

            return largestPrimeFactor;
        }

        private long GetLargestPrimeFactorFromOddNumber(long oddNumber)
        {
            long largestPrimeFactor;
            if (oddNumber <= 1) return 0;
            long auxiliaryNumber = oddNumber;

            long fator = 3;
            var fatorMáximo = Math.Sqrt(auxiliaryNumber);
            long últimoFator = 0;

            while (auxiliaryNumber > 1 && fator <= fatorMáximo)
            {
                if (auxiliaryNumber % fator == 0)
                {
                    auxiliaryNumber = auxiliaryNumber / fator;
                    últimoFator = fator;
                    while (auxiliaryNumber % fator == 0)
                        auxiliaryNumber = auxiliaryNumber / fator;

                    fatorMáximo = Math.Sqrt(auxiliaryNumber);
                }

                fator += 2;
            }
            largestPrimeFactor = auxiliaryNumber;

            return largestPrimeFactor;
        }
    }
}
