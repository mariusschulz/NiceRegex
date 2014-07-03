using Xunit;

namespace NiceRegex.UnitTests.Methods
{
    public class StartOfLineTests
    {
        [Fact]
        public void RendersAStartOfStringOrLineAnchor()
        {
            var niceRegex = RegularExpression.New().StartOfStringOrLine();
            Assert.Equal("^", niceRegex.ToString());
        }

        [Fact]
        public void RendersAStartOfStringAnchor()
        {
            var niceRegex = RegularExpression.New().StartOfString();
            Assert.Equal(@"\A", niceRegex.ToString());
        }
    }
}
