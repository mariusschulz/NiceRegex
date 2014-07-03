﻿namespace NiceRegex
{
    public abstract class RegularExpression : IRegularExpression
    {
        public abstract string GetStringRepresentation();

        public IRegularExpression Then(string literal)
        {
            return new Concatenation(this, Literal(literal));
        }

        public static IRegularExpression New()
        {
            return Epsilon.Instance;
        }

        private static Literal Literal(string literal)
        {
            return new Literal(literal);
        }

        public override sealed string ToString()
        {
            return GetStringRepresentation();
        }
    }
}
