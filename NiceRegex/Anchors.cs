namespace NiceRegex
{
    internal class Anchors
    {
        public static readonly Anchor StartOfString;
        public static readonly Anchor StartOfStringOrLine;

        public static readonly Anchor EndOfStringOrLine;
        public static readonly Anchor EndOfString;
        public static readonly Anchor VeryEndOfString;

        static Anchors()
        {
            StartOfString = new Anchor(@"\A");
            StartOfStringOrLine = new Anchor("^");

            EndOfStringOrLine = new Anchor("$");
            EndOfString = new Anchor(@"\Z");
            VeryEndOfString = new Anchor(@"\z");
        }
    }
}
