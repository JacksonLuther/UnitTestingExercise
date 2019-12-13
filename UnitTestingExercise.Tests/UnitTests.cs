using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(5, 6, 7, 18)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Add(num1, num2, num3);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(10, 9, 1)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(3, 3, 9)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Multiply(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            int actual = challenger.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void GetHello()
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            string actual = challenger.GetHello();
            //Assert
            Assert.Equal("Hello", actual);
        }

        [Fact]
        public void GetGoHome()
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            string actual = challenger.GetGoHome();
            //Assert
            Assert.Equal("Go Home", actual);
        }
    }
}
