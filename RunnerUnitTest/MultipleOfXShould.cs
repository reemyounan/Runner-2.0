using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RC = Runner.ConcreteStep;
using Runner.Problem;
namespace RunnerUnitTest.MultiplesOfX
{
    [TestClass]
    public class MultipleOfXShould
    {
        //Construction
        [TestMethod]
        [ExpectedException(typeof(Exception),
            "Cannot generate multiples of Zero. Please make sure to use a number greater than ZERO")]
        public void ConstructException_WhenDivisorIsLessThanOrEqualToZero()
        {
            //arrange
            var _mockProblem = new Moq.Mock<Problem>();
            RC.MultiplesOfX MultipleOf0 = new RC.MultiplesOfX(_mockProblem.Object, 0);
        }

        //GetProblemStatment
        [TestMethod]
        public void GetProblemStatement_WhenValidConstruction()
        {
            //arrange
            var _mockProblem = new Moq.Mock<Problem>();
            _mockProblem.Setup(x => x.GetProblemStatement()).Returns(() => "Multiple of");

            RC.MultiplesOfX MultipleOf3 = new RC.MultiplesOfX(_mockProblem.Object, 3);

            string expected = "Multiple of 3";

            //Act
            string actual = MultipleOf3.GetProblemStatement();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //IsSatisfied
        [TestMethod]
        [ExpectedException(typeof(Exception),
            "Invalid input, please make sure to enter a natural number.")]
        public void isSatisfied_WhenInputTypeIsInvalid()
        {
            //arrang
            var _mockProblem = new Moq.Mock<Problem>();
            _mockProblem.Setup(x => x.isSatisfied(Moq.It.IsAny<string>())).Returns(() => false);

            RC.MultiplesOfX MultipleOf3 = new RC.MultiplesOfX(_mockProblem.Object, 3);
            MultipleOf3.isSatisfied("InvalidParameterType");

        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
            "Invalid input, the input cannot be negative or zero.")]
        public void isSatisfied_WhenInputValueIsInvalid()
        {
            //arrang
            var _mockProblem = new Moq.Mock<Problem>();
            _mockProblem.Setup(x => x.isSatisfied(Moq.It.IsAny<string>())).Returns(() => false);

            RC.MultiplesOfX MultipleOf3 = new RC.MultiplesOfX(_mockProblem.Object, 3);
            MultipleOf3.isSatisfied("0");

        }

        [TestMethod]
        public void isSatisfied_WhenInputValueIsValid()
        {
            //arrang
            var _mockProblem = new Moq.Mock<Problem>();
            _mockProblem.Setup(x => x.isSatisfied(Moq.It.IsAny<string>())).Returns(() => false);

            RC.MultiplesOfX MultipleOf3 = new RC.MultiplesOfX(_mockProblem.Object, 3);
            bool expected = true;

            //act
            bool actual = MultipleOf3.isSatisfied("6");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isSatisfied_WhenInputValueIsValid2()
        {
            //arrang
            var _mockProblem = new Moq.Mock<Problem>();
            _mockProblem.Setup(x => x.isSatisfied(Moq.It.IsAny<string>())).Returns(() => false);

            RC.MultiplesOfX MultipleOf3 = new RC.MultiplesOfX(_mockProblem.Object, 3);
            bool expected = false;

            //act
            bool actual = MultipleOf3.isSatisfied("5");

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Solve //
        [TestMethod]
        public void solve_WhenInputValueIsValid()
        {
            //arrang
            var _mockProblem = new Moq.Mock<Problem>();
            _mockProblem.Setup(x => x.isSatisfied(Moq.It.IsAny<string>())).Returns(() => false);
            _mockProblem.Setup(x => x.CheckInputValidity(Moq.It.IsAny<string>())).Returns(() => true);

            RC.MultiplesOfX MultipleOf3 = new RC.MultiplesOfX(_mockProblem.Object, 3);
            string expected = "30";

            //act
            object actual = MultipleOf3.Solve("15").ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void solve_WhenSumWillExceedIntMaxValue()
        {
            //arrang
            var _mockProblem = new Moq.Mock<Problem>();
            _mockProblem.Setup(x => x.isSatisfied(Moq.It.IsAny<string>())).Returns(() => false);
            _mockProblem.Setup(x => x.CheckInputValidity(Moq.It.IsAny<string>())).Returns(() => true);

            RC.MultiplesOfX MultipleOf3 = new RC.MultiplesOfX(_mockProblem.Object, 3);
            string expected = "30";

            //act
            object actual = MultipleOf3.Solve("15").ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
