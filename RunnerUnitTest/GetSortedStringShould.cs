using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RC = Runner.ConcreteStep;
using Runner.Problem;

namespace RunnerUnitTest
{
    [TestClass]
    public class GetSortedStringShould
    {
        //GetProblemStatment
        [TestMethod]
        public void GetProblemStatement_WhenValidConstruction()
        {
            //arrange
            var _mockProblem = new Moq.Mock<Problem>();
            _mockProblem.Setup(x => x.GetProblemStatement()).Returns(() => "Sequence Analysis:");

            RC.GetSortedString SortedStringProblem = new RC.GetSortedString(_mockProblem.Object);

            string expected = "Sequence Analysis: sorted";

            //Act
            string actual = SortedStringProblem.GetProblemStatement();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        
        //Solve //
        [TestMethod]
        public void solve_WhenInputValueIsValid()
        {
            //arrange
            var _mockProblem = new Moq.Mock<Problem>();
            _mockProblem.Setup(x => x.Solve(Moq.It.IsAny<string>())).Returns(() => "ISSTRING");

            RC.GetSortedString SortedStringProblem = new RC.GetSortedString(_mockProblem.Object);

            string expected = "GIINRSST";

            //Act
            string actual = SortedStringProblem.Solve("This IS a STRING").ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}