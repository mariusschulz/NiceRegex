namespace NiceRegex
{
    internal class Anchors
    {
        public static readonly Anchor StartOfStringOrLine;

        static Anchors()
        {
            StartOfStringOrLine = new Anchor("^");
        }
    }
}
