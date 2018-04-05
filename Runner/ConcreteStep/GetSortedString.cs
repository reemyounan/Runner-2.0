using Runner.Decorator;
using System.Linq;
namespace Runner.ConcreteStep
{
    public class GetSortedString : StepDecorator
    {
        public GetSortedString(Problem.Problem problem) : base(problem) => ProblemStatement = $"sorted";

        public override string GetProblemStatement() =>  $"{_problem.GetProblemStatement()} {ProblemStatement}";
       public override bool isSatisfied(string input) => true;
        public override object Solve(string input)
        {
            _problem.CheckInputValidity(input);
            string inputInnerSolved = _problem.Solve(input).ToString();
            string sortedString = string.Concat(inputInnerSolved.OrderBy(c => c));
            return sortedString;
        }
    }
}

