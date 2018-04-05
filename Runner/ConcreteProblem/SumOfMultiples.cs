using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Runner.Helpers;

namespace Runner.ConcreteProblem
{
    public class SumOfMultiples : Problem.Problem
    {
        public SumOfMultiples() => ProblemStatement =
            "Sum Of Multiple: Sum of multiples of";

        public override bool CheckInputValidity(string input)
        {
            try
            {
                input.naturalNumberChecker();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public override string GetProblemStatement() => ProblemStatement;

        public override object Solve(string input) => input;
       public override bool isSatisfied(string input) => false;

    }
}
