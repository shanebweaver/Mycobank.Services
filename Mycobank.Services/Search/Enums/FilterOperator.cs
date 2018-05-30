namespace Mycobank.Services.Search.Enums
{
    /// <summary>
    /// Internal enum used by the search logic
    /// </summary>
    internal enum FilterOperator
    {
        And,
        Or,
        Not,
        First // Used by the first filter, to indicate it doesn't need a filter join
    }
}