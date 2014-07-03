using System.Text.RegularExpressions;
using Xunit;

namespace NiceRegex.UnitTests.Methods
{
    public class ThenTests
    {
        [Fact]
        public void AppendsAStringLiteral()
        {
            var niceRegex = RegularExpression.New().Then("a");
            Assert.Equal("a", niceRegex.ToString());
        }

        [Fact]
        public void AppendsACharacterLiteral()
        {
            var niceRegex = RegularExpression.New().Then('a');
            Assert.Equal("a", niceRegex.ToString());
        }

        [Fact]
        public void EscapesSpecialCharacters()
        {
            char[] someSpecialCharacters = @".$^{[(|)*+?\".ToCharArray();

            foreach (char specialCharacter in someSpecialCharacters)
            {
                var niceRegex = RegularExpression.New().Then(specialCharacter);
                string escaped = Regex.Escape(specialCharacter.ToString());

                Assert.Equal(escaped, niceRegex.ToString());
            }
        }
    }
}
