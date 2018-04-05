using Runner.Decorator;
using Runner.Helpers;
using System;

namespace Runner.ConcreteStep
{
    public class MultiplesOfX : StepDecorator
    {
        Int64 _divisor = 1;

        public MultiplesOfX(Problem.Problem problem, Int64 X) : base(problem)
        {
            if (X <= 0)
                throw new Exception("Cannot generate multiples of Zero. Please make sure to use a number greater than ZERO");
            ProblemStatement = $"{X.ToString() }";
            _divisor = X;
        }

        public override string GetProblemStatement() => $"{_problem.GetProblemStatement()} {ProblemStatement}";
        public override bool isSatisfied(string input)
        {

            try { input.naturalNumberChecker(); } catch (Exception ex) { throw ex; }

            return
                (Convert.ToInt64(input) % _divisor == 0) || _problem.isSatisfied(input);
        }
        public override object Solve(string upperBound)
        {
            _problem.CheckInputValidity(upperBound);
            Int64 Sum = 0;
            for (int i = 1; i < Convert.ToInt64(upperBound); i++)
            {
                if (isSatisfied(i.ToString()))
                {
                    try
                    {
                        Sum += i;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Cannot calculate the sum as it exceeded the max value that could be calculated on this computer.");
                    }
                }
            }
            return Sum;


        }
    }
}
