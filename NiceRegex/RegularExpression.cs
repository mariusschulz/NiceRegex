namespace NiceRegex
{
    public abstract class RegularExpression : IRegularExpression
    {
        public abstract string GetStringRepresentation();

        public IRegularExpression Then(char character)
        {
            return Then(character.ToString());
        }

        public IRegularExpression Then(string literal)
        {
            return ConcatenateThisWith(Literal(literal));
        }

        public IRegularExpression Pattern(string pattern)
        {
            return ConcatenateThisWith(new RawPattern(pattern));
        }

        public static IRegularExpression New()
        {
            return Epsilon.Instance;
        }

        private IRegularExpression ConcatenateThisWith(IRegularExpression expression)
        {
            return new Concatenation(this, expression);
        }

        private static Literal Literal(string literal)
        {
            return new Literal(literal);
        }

        public override sealed string ToString()
        {
            return GetStringRepresentation();
        }
    }
}
