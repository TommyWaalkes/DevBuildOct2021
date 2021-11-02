using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDD
{
    public class TestFizzBuzz
    {
        [Theory]
        [InlineData(3, "fizz")]
        [InlineData(9, "fizz")]
        [InlineData(5, "buzz")]
        [InlineData(10, "buzz")]
        [InlineData(15, "fizzbuzz")]
        [InlineData(45, "fizzbuzz")]
        [InlineData(13, "")]
        public void TestFB(int num, string expected)
        {
            FizzBuzz fb = new FizzBuzz();
            string actual = fb.GetFizzBuzz(num);
            Assert.Equal(expected, actual);
        }
    }
}
