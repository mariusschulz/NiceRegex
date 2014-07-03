namespace NiceRegex
{
    public class RegularExpression : IRegularExpression
    {
        private RegularExpression()
        {
            
        }

        public static IRegularExpression New()
        {
            return new RegularExpression();
        }
    }
}
