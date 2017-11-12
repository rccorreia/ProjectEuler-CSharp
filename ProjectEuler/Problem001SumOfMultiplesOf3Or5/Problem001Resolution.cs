using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problem001SumOfMultiplesOf3Or5
{
    public class Problem001Resolution
    {
        public int SumOfAllTheMultiplesOf3Or5Below1000()
        {
            var mathOperations = new MathOperationsForProblem001();
            var multiplesOf3Or5 = new List<int>();

            var multiplesOf3 = mathOperations.GetMultiplesOfANumberInAPeriod(3, new Period(0, 999));
            var multiplesOf5 = mathOperations.GetMultiplesOfANumberInAPeriod(5, new Period(0, 999));

            multiplesOf3Or5.AddRange(multiplesOf3);
            multiplesOf3Or5.AddRange(multiplesOf5);

            return mathOperations.SumNumbersFromAList(multiplesOf3Or5.Distinct().ToList());
        }
    }
}
