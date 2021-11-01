using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing
{
    public class TestCalculator
    {
        [Fact]
        //I make my unit test names long and descriptive
        public void OnePlusTwoShouldBeThree()
        {
            //Arrange - setup all the needed variables and objects
            Calculator c = new Calculator();
            double expected = 3;

            //Act - this is where we run the code we wish to test 
            double actual = c.Add(1, 2);

            //Assert - compare expected vs actual
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void twoPlusTwoIsFour()
        {
            //Arrange
            Calculator c = new Calculator();
            double expected = 4;

            //Act 
            double actual = c.Add(2, 2);

            //Assert 
            Assert.Equal(expected, actual);
        }


        [Theory]

        //Inline creates a test input 
        //it must match the parameters of the test method
        [InlineData(2,2)]
        [InlineData(1,2)]
        [InlineData(3,3)]
        [InlineData(5,3)]
        [InlineData(473, 192)]
        [InlineData(1002, 9882)]
        
        //The Parameter here hook into the theory
        public void TestAdd(int num1, int num2)
        {
            //Arrange
            Calculator c = new Calculator();
            double expected = num1 + num2;

            //Act 
            double actual = c.Add(num1, num2);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,0)]
        [InlineData(10, 10)]
        [InlineData(5, 20)]
        [InlineData(11, 2)]
        [InlineData(-19, -100)]
        [InlineData(-10, 2)]
        public void TestDivide(double num1, double num2)
        {
            //Arrange 
            Calculator c = new Calculator();
            double expected = num1 / num2;

            //Act 
            double actual = c.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        //[Fact]
        //public void DivideByZeroThrowsException()
        //{
        //    Calculator c = new Calculator();

        //   Assert.Throws(typeof(DivideByZeroException), c.Divide(10, 0));
        //}
    }
}
