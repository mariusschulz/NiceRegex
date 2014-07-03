namespace NiceRegex
{
    public abstract class RegularExpression : IRegularExpression
    {
        public abstract string GetStringRepresentation();

        public static IRegularExpression New()
        {
            return Epsilon.Instance;
        }

        public sealed override string ToString()
        {
            return GetStringRepresentation();
        }
    }
}
