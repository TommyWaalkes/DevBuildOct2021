using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDD
{
    public class PrimeTester
    {
        //We'll ignore the following numbers for checking for primes:2, 1 and 0 

        [Theory]
        [InlineData(4, "even")]
        [InlineData(6, "even")]
        [InlineData (10, "even")]
        [InlineData(72, "even")]
        [InlineData(9, "odd")]
        [InlineData(15, "odd")]
        [InlineData(21, "odd")]
        [InlineData(85, "odd")]
        [InlineData(5, "prime")]
        [InlineData(73, "prime")]
        [InlineData(2, "prime")]
        [InlineData(1, "odd")]
        [InlineData(0, "even")]
        public void TestEvenOrOddOrPrime(int num, string expected)
        {
            PrimeFinder p = new PrimeFinder();

            string actual = p.EvenOddOrPrime(num);

            Assert.Equal(expected, actual);
        }


    }
}
