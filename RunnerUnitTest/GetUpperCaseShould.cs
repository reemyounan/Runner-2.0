using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RC = Runner.ConcreteStep;
using Runner.Problem;

namespace RunnerUnitTest.GetUpperCase
{
    [TestClass]
    public class GetUpperCaseShould
    {
        //GetProblemStatment
        [TestMethod]
        public void GetProblemStatement_WhenValidConstruction()
        {
            //arrange
            var _mockProblem = new Moq.Mock<Problem>();
            _mockProblem.Setup(x => x.GetProblemStatement()).Returns(() => "Sequence Analysis: ");

            RC.GetUpperCase UpperCaseProblem = new RC.GetUpperCase(_mockProblem.Object);

            string expected = "Sequence Analysis:  upper case words";

            //Act
            string actual = UpperCaseProblem.GetProblemStatement();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //IsSatisfied

        [TestMethod]
        public void isSatisfied_WhenInputValueIsValid()
        {
            //arrang
            var _mockProblem = new Moq.Mock<Problem>();

            RC.GetUpperCase UpperCaseProblem = new RC.GetUpperCase(_mockProblem.Object);

            bool expected = true;

            //act
            bool actual = UpperCaseProblem.isSatisfied("THIS");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isSatisfied_WhenInputValueIsValid2()
        {
            //arrang
            var _mockProblem = new Moq.Mock<Problem>();

            RC.GetUpperCase UpperCaseProblem = new RC.GetUpperCase(_mockProblem.Object);

            bool expected = false;

            //act
            bool actual = UpperCaseProblem.isSatisfied("TiIS");

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Solve //
        [TestMethod]
        public void solve_WhenInputValueIsValid()
        {
            //arrange
            var _mockProblem = new Moq.Mock<Problem>();
            _mockProblem.Setup(x => x.Solve(Moq.It.IsAny<string>())).Returns(() => "This IS a STRING");

            RC.GetUpperCase UpperCaseProblem = new RC.GetUpperCase(_mockProblem.Object);

            string expected = "ISSTRING";

            //Act
            string actual = UpperCaseProblem.Solve("This IS a STRING").ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
