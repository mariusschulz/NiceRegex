using System.Text.RegularExpressions;

namespace NiceRegex
{
    internal class Literal : RegularExpression
    {
        private readonly string _escapedLiteral;

        public Literal(string literal)
        {
            _escapedLiteral = Regex.Escape(literal);
        }

        public override string GetStringRepresentation()
        {
            return _escapedLiteral;
        }
    }
}
