using Xunit;

namespace NiceRegex.UnitTests.Methods
{
    public class PatternTests
    {
        [Fact]
        public void AppendsARegexPatternAsIs()
        {
            var niceRegex = RegularExpression.New().Pattern(".+?");
            Assert.Equal(".+?", niceRegex.ToString());
        }
    }
}
