using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Blockbuster;

namespace UnirTests
{
    public class TestMovie
    {
        [Fact]
        //Test methods are always void 
        public void TestMoiveToString()
        {
            //Arrange 
            Movie m = new Movie("Jim", Genre.Action, 20, "first", "second");
            string expected = $"Title: {m.Title}\nCategory: {m.Category}\nRun Time: {m.Runtime}\n";

            //Act 
            string actual = m.ToString();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestVHSRewind()
        {
            VHS v = new VHS("Jim", Genre.Action, 20, "first", "second");
            v.CurrentTime = 10;
            v.Rewind();

            Assert.Equal(0, v.CurrentTime);
        }

        //public Movie TestM { get; set; } = new Movie("Jim", Genre.Action, 20, "first", "second");

        //Theories can't hande passing in objects 
        [Theory]
        [InlineData("movie", "The children of movie MUST create their own play method")]
        [InlineData("vhs", "first")]
        [InlineData("dvd", "first")]
        public void TestPlay(string movieType, string expected)
        {
            Movie m = MovieCreator(movieType);

            string actual = m.Play();

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(0, "first")]
        [InlineData(1, "second")]
        [InlineData(2, "third")]
        [InlineData(3, "fourth")]
        [InlineData(4, "rewinding")]
        [InlineData(5, "first")]
        public void TestVHSPlayAndRewind(int timesRun, string expected)
        {
            VHS v = new VHS("Jim", Genre.Action, 20, "first", "second", "third" , "fourth");
            for(int i = 0; i < timesRun; i++)
            {
                v.Play();
            }

            string actual = v.Play();

            Assert.Equal(expected, actual);
        }

        //This is a helper method that allows us to easily pick 
        //what movie type we want to test 
        //This is useful for testing inheritance
        public Movie MovieCreator(string movieType)
        {
            Movie m;
            if (movieType == "movie")
            {
                m = new Movie("Jim", Genre.Action, 20, "first", "second");
            }
            else if (movieType == "vhs")
            {
                m = new VHS("Jim", Genre.Action, 20, "first", "second");
            }
            else
            {
                m = new DVD("Jim", Genre.Action, 20, "first", "second");
            }

            return m;
        }
    }
}
