namespace NiceRegex
{
    public interface IRegularExpression
    {
        string GetStringRepresentation();

        IRegularExpression Then(string literal);
    }
}
