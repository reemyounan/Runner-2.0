using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Problem
{
    public interface IProblem
    {
        string GetProblemStatement();
        object Solve(string input);
    }
    public abstract class Problem:IProblem
    {
        public string ProblemStatement { get; set; }
        public abstract string GetProblemStatement();

        public abstract object Solve(string input);
        public abstract bool CheckInputValidity(string input);
        public abstract bool isSatisfied(string input);
    }
}
