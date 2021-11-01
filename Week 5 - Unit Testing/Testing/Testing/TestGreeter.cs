using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing
{
    public class TestGreeter
    {
        [Fact]
        public void TestGreetTommy()
        {
            //Arrange
            Greeter g = new Greeter();

            //Notice I wrote out my expected rather than calculating 
            //That's the main difference 
            string expected = "Hello Tommy!";

            //Act 
            string actual = g.Greet("Tommy");

            //Assert 
            Assert.Equal(expected, actual);
        }

        //This is a generalized version of GreetTommy
        //While inline mostly is used for  test inputs 
        //it can be used for any other job as well EX: setting up the expected 
        [Theory]
        [InlineData("Tommy", "Hello Tommy!")]
        [InlineData("Bill", "Hi Bill")]
        [InlineData("Jose", "Hi Jose")]
        [InlineData("Jenifer", "Hello Jenifer!")]
        [InlineData("", "Oh a mysterious stranger")]
        public void TestGreet(string name, string expected)
        {
            //Arrange
            Greeter g = new Greeter();

            //Notice I wrote out my expected rather than calculating 
            //That's the main difference 

            //Act 
            string actual = g.Greet(name);

            //Assert 
            Assert.Equal(expected, actual);
        }
    }
}
