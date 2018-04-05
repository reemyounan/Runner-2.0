using Runner.Decorator;
using System.Linq;

namespace Runner.ConcreteStep
{
    public class GetUpperCase : StepDecorator
    {
        public GetUpperCase(Problem.Problem problem) : base(problem) => ProblemStatement = $"upper case words";

        public override string GetProblemStatement() => $"{_problem.GetProblemStatement()} {ProblemStatement}";
        public override bool isSatisfied(string input) => (input.All(c => char.IsUpper(c)));
        public override object Solve(string input)
        {
            _problem.CheckInputValidity(input);
            string inputInnerSolved = _problem.Solve(input).ToString();
            string[] words = inputInnerSolved.Split(' ');
            string capitalWords = "";

            foreach (string word in words)
            {
                if (isSatisfied(word))
                    capitalWords += word;
            }
            return capitalWords;
        }
    }
}
