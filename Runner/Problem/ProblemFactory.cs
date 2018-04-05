using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Runner.Problem;
using Runner.ConcreteStep;
using Runner.ConcreteProblem;

namespace Runner.Problem
{
    public static class ProblemFactory
    {
        private static Dictionary<int, IProblem> _problems = new Dictionary<int, IProblem>();
        private static Dictionary<int, string> _problemStatements = new Dictionary<int, string>();

        static ProblemFactory()
        {
            #region Create problems available for runner

            // Add "sum of multiples" 
            Problem multiplesOf3And5 = new SumOfMultiples();
            multiplesOf3And5 = new MultiplesOfX(multiplesOf3And5, 3);
            multiplesOf3And5 = new MultiplesOfX(multiplesOf3And5, 5);
            _problems.Add(1, multiplesOf3And5);

            // Add "sequence analysis" to the dictionary of available problems
            Problem sequenceAnalyser = new SequenceAnalysis();
            sequenceAnalyser = new GetUpperCase(sequenceAnalyser);
            sequenceAnalyser = new GetSortedString(sequenceAnalyser);
            _problems.Add(2, sequenceAnalyser);


            #endregion

            #region Create problem statements corresponding to the set of available problems
            foreach (KeyValuePair<int, IProblem> pair in _problems)
            {
                _problemStatements.Add(pair.Key, pair.Value.GetProblemStatement());
            }
            #endregion

        }

        public static IProblem Create(int SelectedProblem)
        {
            if (_problems.Keys.Contains(SelectedProblem))
                return _problems[SelectedProblem];
            else
                throw new Exception("Problem does not belong to the pool of problems");
        }

        public static Dictionary<int, string> GetProblems()
        {
            return _problemStatements;
        }
    }
}
