using System;
using ProjectEuler.Problem001SumOfMultiplesOf3Or5;
using ProjectEuler.Problem002EvenFibonacciNumbers;
using ProjectEuler.Problem003LargestPrimeFactor;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem001Resolution = new Problem001Resolution();
            var problem001Answer = problem001Resolution.SumOfAllTheMultiplesOf3Or5Below1000();

            Console.WriteLine($"Problem 001 Answer = { problem001Answer }");

            var problem002Resolution = new Problem002Resolution();
            var problem002Answer = problem002Resolution.SumOfTheEvenNumbersBelow4Million();

            Console.WriteLine($"Problem 002 Answer = { problem002Answer }");

            var problem003Resolution = new Problem003Resolution();
            var problem003Answer = problem003Resolution.GetTheLargestPrimeFactorOfTheNumber600851475143();

            Console.WriteLine($"Problem 003 Answer = { problem003Answer }");
        }
    }
}
