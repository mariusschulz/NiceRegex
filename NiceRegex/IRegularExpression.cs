namespace NiceRegex
{
    public interface IRegularExpression
    {
        string GetStringRepresentation();

        IRegularExpression Then(char character);
        IRegularExpression Then(string literal);
        IRegularExpression Pattern(string pattern);

        // Anchors
        IRegularExpression StartOfString();
        IRegularExpression StartOfStringOrLine();
        IRegularExpression EndOfStringOrLine();
        IRegularExpression EndOfString();
        IRegularExpression VeryEndOfString();
        IRegularExpression WordBoundary();
    }
}
