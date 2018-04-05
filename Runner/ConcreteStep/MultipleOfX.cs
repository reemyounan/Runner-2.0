using Runner.Decorator;
using System;

namespace Runner.ConcreteStep
{
    class MultiplesOfX : StepDecorator
    {
        Int64 _divisor = 1;

        public MultiplesOfX(Problem.Problem problem, Int64 X) : base(problem)
        {
            ProblemStatement = $"{X.ToString() }";
            _divisor = X;
        }

        public override string GetProblemStatement() => $"{_problem.GetProblemStatement()} {ProblemStatement}";
        public override bool isSatisfied(string input) => (Convert.ToInt64(input) % _divisor == 0) || _problem.isSatisfied(input);
        public override object Solve(string upperBound)
        {
            _problem.CheckInputValidity(upperBound);
            Int64 Sum = 0;
            for (int i = 0; i < Convert.ToInt64(upperBound); i++)
            {
                if (isSatisfied(i.ToString()))
                    Sum += i;
            }
            return Sum;


        }
    }
}
