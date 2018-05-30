namespace Mycobank.Services.Search.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum ComparisonOperator
    {
        EqualTo,
        LessThan,
        GreaterThan,
        Different,
        LessThanOrEqualTo,
        GreaterThanOrEqualTo,
        Contains,
        StartsWith,
        EndsWith
    }

    internal static class ComparisonOperatorExtensions
    {
        /// <summary>
        /// Helper method to get string values from the ComparisonOperator enum
        /// 
        /// NOTE: All operators are case sensitive.
        /// </summary>
        /// <param name="comparisonOperator"></param>
        /// <returns></returns>
        internal static string GetOperatorValue(this ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.EqualTo: return "=";
                case ComparisonOperator.LessThan: return "<";
                case ComparisonOperator.GreaterThan: return ">";
                case ComparisonOperator.Different: return "<>";
                case ComparisonOperator.LessThanOrEqualTo: return "<=";
                case ComparisonOperator.GreaterThanOrEqualTo: return ">=";
                case ComparisonOperator.Contains: return " CONTAINS ";
                case ComparisonOperator.StartsWith: return " STARTSWITH ";
                case ComparisonOperator.EndsWith: return " ENDSWITH ";
                default: throw new System.ArgumentOutOfRangeException();
            }
        }
    }
}