using Xunit;
using MyLibrary;

namespace MyTestProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void EmptyOrNullTest(string str)
        {
            var (flag, msg) = str.IsInt();

            Assert.False(flag);
            Assert.Equal("empty", msg);
        }

        [Fact]
        public void IntTest()
        {
            var (flag, msg) = "123".IsInt();

            Assert.True(flag);
            Assert.Equal(string.Empty, msg);
        }

        [Fact]
        public void NotIntTest()
        {
            var (flag, msg) = "abc".IsInt();

            Assert.False(flag);
            Assert.Equal("invalid", msg);
        }
    }
}