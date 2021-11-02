using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDD
{
    public class PasswordAppTest
    {
        [Theory]
        [InlineData("tomy45678", false)]
        [InlineData("hot pocket 1", false)]
        [InlineData(null, false)]
        [InlineData("12345678", false)]
        [InlineData("Hotpocket1945", true)]
        [InlineData("TommyWaalkes", false)]

        //null == nihil - nihilism, nemo

        //? means nullable, nullable means the variable will allow nulls 
        public void TestVerify(string? input, bool expected)
        {
            PasswordApp p = new PasswordApp();
            bool actual = p.Verify(input);

            //Make sure expected is put first, otherwise your 
            //Test failure messages will be confusing 
            Assert.Equal(expected, actual);
        }
    }
}
