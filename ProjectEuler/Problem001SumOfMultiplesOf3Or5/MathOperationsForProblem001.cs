using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problem001SumOfMultiplesOf3Or5
{
    public class MathOperationsForProblem001
    {
        public List<int> IdentifyMultiplesOfANumberInAPeriod(int number, Period period)
        {
            if (number == 0)
                throw new Exception("The number should not be zero");

            var multiples = new List<int>();

            for(int i = period.Begin; i <= period.End; i++)
            {
                if (i == 0) continue;

                if (i % number == 0)
                    multiples.Add(i);
            }

            return multiples;
        }

        public int SumNumbersFromAList(List<int> numbers)
        {
            return numbers.Sum();
        }
    }
}
