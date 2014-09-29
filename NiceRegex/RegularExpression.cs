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
            return Append(Literal(literal));
        }

        public IRegularExpression Pattern(string pattern)
        {
            return Append(new RawPattern(pattern));
        }

        public IRegularExpression StartOfString()
        {
            return Append(Anchors.StartOfString);
        }

        public IRegularExpression StartOfStringOrLine()
        {
            return Append(Anchors.StartOfStringOrLine);
        }

        public IRegularExpression EndOfStringOrLine()
        {
            return Append(Anchors.EndOfStringOrLine);
        }

        public IRegularExpression EndOfString()
        {
            return Append(Anchors.EndOfString);
        }

        public IRegularExpression VeryEndOfString()
        {
            return Append(Anchors.VeryEndOfString);
        }

        public IRegularExpression WordBoundary()
        {
            return Append(Anchors.WordBoundary);
        }

        public IRegularExpression NonWordBoundary()
        {
            return Append(Anchors.NonWordBoundary);
        }

        public static IRegularExpression New()
        {
            return Epsilon.Instance;
        }

        private IRegularExpression Append(IRegularExpression expression)
        {
            return new Concatenation(this, expression);
        }

        private static Literal Literal(string literal)
        {
            return new Literal(literal);
        }
    }
}
