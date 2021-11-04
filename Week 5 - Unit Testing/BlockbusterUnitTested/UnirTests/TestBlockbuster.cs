using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Blockbuster;

namespace UnirTests
{
    public class TestBlockbuster
    {
        [Theory]
        [InlineData(0, "28 Days Later")]
        [InlineData(5, "Apacolypse Now")]
        public void TestGetMovie(int index, string expectedTitle)
        {
            BlockbusterVideo b = new BlockbusterVideo();
            Movie m = b.GetMovie(index);
            
            string actualTitle = m.Title;

            Assert.Equal(expectedTitle, actualTitle);
        }

        [Fact]
        public void GetMovieReturnsNull()
        {
            BlockbusterVideo b = new BlockbusterVideo();
           // Movie expected = null;
            Movie actual = b.GetMovie(50);

            Assert.Null(actual);
        }
    }
}
