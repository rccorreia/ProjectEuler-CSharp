namespace ProjectEuler.Problem003LargestPrimeFactor
{
    public class Problem003Resolution
    {
        public long GetTheLargestPrimeFactorOfTheNumber600851475143()
        {
            var mathOperations = new MathOperationsForProblem003();

            return mathOperations.GetLargestPrimeFactorFromNumber(600851475143);
        }
    }
}
