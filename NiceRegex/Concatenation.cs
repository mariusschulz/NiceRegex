using System.Collections.Generic;
using NiceRegex.Extensions;

namespace NiceRegex
{
    internal class Concatenation : RegularExpression
    {
        private readonly IEnumerable<IRegularExpression> _expressions;

        public Concatenation(IRegularExpression left, IRegularExpression right)
            : this(new[] { left, right })
        {
            // Nothing to do here
        }

        private Concatenation(IEnumerable<IRegularExpression> expressions)
        {
            _expressions = expressions;
        }

        public override string GetStringRepresentation()
        {
            return _expressions.StringJoin();
        }
    }
}
