using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDD
{
    public class DiamondTest
    {
        [Theory]
        [InlineData('a')]
       

        public void TestDiamondCreation(char letter)
        {
            //Arrange 
            Diamond d = new Diamond();
            string expected = "A";

            //Act 
            string actual = d.GetDiamond(letter);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestB()
        {
            Diamond d = new Diamond();
            string expected = "A\nB B\nA";

            string actual = d.GetDiamond('b');

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData('A', 'C', "  ")]
        [InlineData('B', 'C', " ")]
        [InlineData('C', 'C', "   ")]
        public void TestGetSpaces(char current, char end, string expected)
        {
            Diamond d = new Diamond();
            string actual = d.GetSpaces(current, end);
            
            Assert.Equal(expected.Length, actual.Length);

        }
    }
}
