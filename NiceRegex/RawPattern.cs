namespace NiceRegex
{
    public class RawPattern : RegularExpression
    {
        private readonly string _pattern;

        public RawPattern(string pattern)
        {
            _pattern = pattern;
        }

        public override string GetStringRepresentation()
        {
            return _pattern;
        }
    }
}
