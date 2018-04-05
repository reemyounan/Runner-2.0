using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Decorator
{
    class StepDecorator : Problem.Problem
    {
        protected Problem.Problem _problem;

        public StepDecorator(Problem.Problem problem) => _problem = problem;

        public override string GetProblemStatement() => _problem.GetProblemStatement();
        public override object Solve(string input)
        {
            return _problem.Solve(input);
        }
        public override bool CheckInputValidity(string input) => _problem.CheckInputValidity(input);
        public override bool isSatisfied(string input) => _problem.isSatisfied(input);
    }
}
