using Xunit;

namespace NiceRegex.UnitTests
{
    public class RegularExpressionTests
    {
        [Fact]
        public void NewReturnsNonNullInstances()
        {
            IRegularExpression niceRegex = RegularExpression.New();
            Assert.NotNull(niceRegex);
        }

        [Fact]
        public void ReturnsAnEmptyPatternForEmptyInputs()
        {
            var niceRegex = RegularExpression.New();
            string pattern = niceRegex.ToString();

            Assert.Equal(string.Empty, pattern);
        }
    }
}
