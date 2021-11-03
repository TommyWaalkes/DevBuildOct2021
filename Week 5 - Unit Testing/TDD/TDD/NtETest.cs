using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDD
{
    public class NtETest
    {
        [Theory]
        [InlineData(1, "one")]
        [InlineData(2,"two")]
        [InlineData(3, "three")]
        [InlineData(4, "four")]
        [InlineData(5, "five")]
        [InlineData(6, "six")]
        [InlineData(7, "seven")]
        [InlineData(8, "eight")]
        [InlineData(9, "nine")]
        [InlineData(0, "zero")]
        public void TestOnes(double num, string expected)
        {
            //Arrange 
            NumberToEnglish n = new NumberToEnglish();

            //Act 
            string actual = n.NumToEnglish(num);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, "ten")]
        [InlineData(11, "eleven")]
        [InlineData(12, "twelve")]
        [InlineData(13, "thirteen")]
        [InlineData(14, "fourteen")]
        [InlineData(15, "fifteen")]
        [InlineData(16, "sixteen")]
        [InlineData(17, "seventeen")]
        [InlineData(18, "eighteen")]
        [InlineData(19, "nineteen")]
        [InlineData(20, "twenty")]
        [InlineData(21, "twenty one")]
        [InlineData(30, "thirty")]
        [InlineData(32, "thirty two")]
        [InlineData(40, "fourty")]
        [InlineData(50, "fifty")]
        [InlineData(60, "sixty")]
        [InlineData(70, "seventy")]
        [InlineData(80, "eighty")]
        [InlineData(90, "ninety")]
        //While we could reuse testones, there will be so many test cases 
        //That it makes more sense to keep them separate to prevent clutter
        public void TestTens(double num, string expected)
        {
            //Arrange 
            NumberToEnglish n = new NumberToEnglish();

            //Act 
            string actual = n.NumToEnglish(num);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(100, "one hundred")]
        [InlineData(157, "one hundred fifty seven")]
        [InlineData(500, "five hundred")]
        [InlineData(932, "nine hundred thirty two")]

        public void TestHundreds(double num, string expected)
        {
            //Arrange 
            NumberToEnglish n = new NumberToEnglish();

            //Act 
            string actual = n.NumToEnglish(num);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
