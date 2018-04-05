using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Runner.Helpers;

namespace Runner.ConcreteProblem
{
    class SequenceAnalysis : Problem.Problem
    {
        public SequenceAnalysis() => ProblemStatement = "Sequence Analysis: ";

        public override bool CheckInputValidity(string input)
        {
            try
            {
                input.stringChecker();
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
