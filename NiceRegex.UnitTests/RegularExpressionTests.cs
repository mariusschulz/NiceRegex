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
    }
}
