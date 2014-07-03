namespace NiceRegex
{
    public abstract class RegularExpression : IRegularExpression
    {
        public abstract string GetStringRepresentation();

        public override sealed string ToString()
        {
            return GetStringRepresentation();
        }

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

        public IRegularExpression StartOfString()
        {
            return ConcatenateThisWith(Anchors.StartOfString);
        }

        public IRegularExpression StartOfStringOrLine()
        {
            return ConcatenateThisWith(Anchors.StartOfStringOrLine);
        }

        public IRegularExpression EndOfStringOrLine()
        {
            return ConcatenateThisWith(Anchors.EndOfStringOrLine);
        }

        public IRegularExpression EndOfString()
        {
            return ConcatenateThisWith(Anchors.EndOfString);
        }

        public IRegularExpression VeryEndOfString()
        {
            return ConcatenateThisWith(Anchors.VeryEndOfString);
        }

        public IRegularExpression WordBoundary()
        {
            return ConcatenateThisWith(Anchors.WordBoundary);
        }

        public IRegularExpression NonWordBoundary()
        {
            return ConcatenateThisWith(Anchors.NonWordBoundary);
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
    }
}
