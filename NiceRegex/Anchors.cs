namespace NiceRegex
{
    internal class Anchors
    {
        public static readonly Anchor StartOfString;
        public static readonly Anchor StartOfStringOrLine;

        static Anchors()
        {
            StartOfString = new Anchor(@"\A");
            StartOfStringOrLine = new Anchor("^");
        }
    }
}
