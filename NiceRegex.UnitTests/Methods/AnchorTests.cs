using Xunit;

namespace NiceRegex.UnitTests.Methods
{
    public class AnchorTests
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

        [Fact]
        public void RendersAnEndOfStringOrLineAnchor()
        {
            var niceRegex = RegularExpression.New().EndOfStringOrLine();
            Assert.Equal("$", niceRegex.ToString());
        }

        [Fact]
        public void RendersAnEndOfStringAnchor()
        {
            var niceRegex = RegularExpression.New().EndOfString();
            Assert.Equal(@"\Z", niceRegex.ToString());
        }

        [Fact]
        public void RendersAVeryEndOfStringAnchor()
        {
            var niceRegex = RegularExpression.New().VeryEndOfString();
            Assert.Equal(@"\z", niceRegex.ToString());
        }

        [Fact]
        public void RendersAWordBoundaryAnchor()
        {
            var niceRegex = RegularExpression.New().WordBoundary();
            Assert.Equal(@"\b", niceRegex.ToString());
        }
    }
}
