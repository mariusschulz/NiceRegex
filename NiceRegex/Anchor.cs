namespace NiceRegex
{
    internal class Anchor : RegularExpression
    {
        private readonly string _symbol;

        internal Anchor(string symbol)
        {
            _symbol = symbol;
        }

        public override string GetStringRepresentation()
        {
            return _symbol;
        }
    }
}
