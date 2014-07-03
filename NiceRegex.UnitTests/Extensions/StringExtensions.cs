using NiceRegex.Extensions;
using Xunit;

namespace NiceRegex.UnitTests.Extensions
{
    public class StringExtensions
    {
        [Fact]
        public void JoinsCollectionsWithEmptyStringAsSeparator()
        {
            char[] letters = { 'a', 'b', 'c' };

            string joinedLetters = letters.StringJoin();

            Assert.Equal("abc", joinedLetters);
        }

        [Fact]
        public void JoinsCollectionsWithCustomSeparator()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            string joinedNumbers = numbers.StringJoin(",");

            Assert.Equal("1,2,3,4,5", joinedNumbers);
        }
    }
}
