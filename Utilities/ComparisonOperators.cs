using System;

namespace VerificationPortals.Utilities{
    /// <summary>
    /// Enumerates the comparison operators.
    /// </summary>
    public enum ComparisonOperators : byte
    {
        LessThan = 1,
        LessThanOrEqualTo = 2,
        EqualTo = 3,
        GreaterThanOrEqualTo = 4,
        GreaterThan = 5
    }
}