using Xunit;

namespace NiceRegex.UnitTests.Methods
{
    public class ThenTests
    {
        [Fact]
        public void AppendsAStringLiteral()
        {
            var niceRegex = RegularExpression.New().Then("a");
            string pattern = niceRegex.ToString();

            Assert.Equal("a", pattern);
        }
    }
}
