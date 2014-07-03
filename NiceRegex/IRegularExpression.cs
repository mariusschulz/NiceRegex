namespace NiceRegex
{
    public interface IRegularExpression
    {
        string GetStringRepresentation();

        IRegularExpression Then(char character);
        IRegularExpression Then(string literal);
        IRegularExpression Pattern(string pattern);
        IRegularExpression StartOfString();
        IRegularExpression StartOfStringOrLine();
        IRegularExpression EndOfStringOrLine();
    }
}
