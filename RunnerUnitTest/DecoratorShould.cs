using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RC = Runner.ConcreteStep;
using Runner.ConcreteProblem;
using Runner.Problem;


namespace RunnerUnitTest
{
    [TestClass]
    public class DecoratorShould
    {
        [TestMethod]
        public void dynamicallyAttachSequenceBehavior()
        {
            Problem sequenceAnalyser = new SequenceAnalysis();
            sequenceAnalyser = new RC.GetUpperCase(sequenceAnalyser);
            sequenceAnalyser = new RC.GetSortedString(sequenceAnalyser);

            string expected = "GIINRSST";

            //act
            string actual = sequenceAnalyser.Solve("This IS a STRING").ToString();

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void dynamicallyAttachSumofMultiplesBehavior()
        {
            Problem sumOfMultiple = new SumOfMultiples();
            sumOfMultiple = new RC.MultiplesOfX(sumOfMultiple, 3);
            sumOfMultiple = new RC.MultiplesOfX(sumOfMultiple, 5);

            string expected = "78";

            //act
            string actual = sumOfMultiple.Solve("20").ToString();

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
