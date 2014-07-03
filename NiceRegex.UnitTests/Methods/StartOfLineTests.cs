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
    }
}
