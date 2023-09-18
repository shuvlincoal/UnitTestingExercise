using System;
using System.Reflection;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(6, 6, 8, 20)]
        [InlineData(10, 10, 20, 40)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            // Creating an ojbect == create instance
            //Calculator instance = new Calculator();
            var calc = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calc.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1, 1, 0)]//Sub test data <-------
        [InlineData(1, 4, 3)]
        [InlineData(7, 21, 14)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Sub(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 8)]//Multiply test data <-------
        [InlineData(13, 2, 26)]
        [InlineData(12, 12, 144)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Mult(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(16, 4, 4)]//Div test data <-------
        [InlineData(18, 9, 2)]
        [InlineData(15, 3, 5)]
        [InlineData(48, 2, 24)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Div(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
