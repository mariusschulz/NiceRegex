namespace NiceRegex
{
    public class Epsilon : RegularExpression
    {
        public static Epsilon Instance;

        private Epsilon()
        {

        }

        static Epsilon()
        {
            Instance = new Epsilon();
        }

        public override string GetStringRepresentation()
        {
            return string.Empty;
        }
    }
}
