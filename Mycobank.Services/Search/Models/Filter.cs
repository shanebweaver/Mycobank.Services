using Mycobank.Services.Search.Enums;

namespace Mycobank.Services.Search.Models
{
    /// <summary>
    /// 
    /// </summary>
    internal struct Filter
    {
        public string FieldCode { get; set; }
        public ComparisonOperator ComparisonOperator { get; set; }
        public string Value { get; set; }
        public string TargetTableName { get; set; }
        public string TargetFieldCode { get; set; }
        public FilterOperator FilterOperator { get; private set; }
        public bool IsLinkField { get; private set; }

        public Filter(FilterOperator filterOperator, string fieldCode, ComparisonOperator comparisonOperator, string value)
        {
            FilterOperator = filterOperator;
            FieldCode = fieldCode;
            TargetTableName = null;
            TargetFieldCode = null;
            ComparisonOperator = comparisonOperator;
            Value = value;
            IsLinkField = false;
        }

        public Filter(FilterOperator filterOperator, string fieldCode, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value)
        {
            FilterOperator = filterOperator;
            FieldCode = fieldCode;
            TargetTableName = targetTableName;
            TargetFieldCode = targetFieldCode;
            ComparisonOperator = comparisonOperator;
            Value = value;
            IsLinkField = true;
        }
    }
}