using Mycobank.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mycobank.Services
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

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Search<T> : ISearch
    {
        public int? Limit { get; private set; }
        private List<Filter> Filters = new List<Filter>();

        internal abstract IReadOnlyDictionary<T, string> SearchCodes { get; }

        internal Search(T searchField, ComparisonOperator comparisonOperator, string value, int? limit = null)
        {
            Limit = limit;
            AddFilter(FilterOperator.First, searchField, comparisonOperator, value);
        }

        internal Search(T searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value, int? limit = null)
        {
            Limit = limit;
            AddFilter(FilterOperator.First, searchField, targetTableName, targetFieldCode, comparisonOperator, value);
        }

        internal Search<T> And(T searchField, ComparisonOperator comparisonOperator, string value)
        {
            AddFilter(FilterOperator.And, searchField, comparisonOperator, value);
            return this;
        }

        internal Search<T> And(T searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value)
        {
            AddFilter(FilterOperator.And, searchField, targetTableName, targetFieldCode, comparisonOperator, value);
            return this;
        }

        internal Search<T> Or(T searchField, ComparisonOperator comparisonOperator, string value)
        {
            AddFilter(FilterOperator.Or, searchField, comparisonOperator, value);
            return this;
        }

        internal Search<T> Or(T searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value)
        {
            AddFilter(FilterOperator.Or, searchField, targetTableName, targetFieldCode, comparisonOperator, value);
            return this;
        }

        internal Search<T> Not(T searchField, ComparisonOperator comparisonOperator, string value)
        {
            AddFilter(FilterOperator.Not, searchField, comparisonOperator, value);
            return this;
        }

        internal Search<T> Not(T searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value)
        {
            AddFilter(FilterOperator.Not, searchField, targetTableName, targetFieldCode, comparisonOperator, value);
            return this;
        }

        private void AddFilter(FilterOperator filterOperator, T searchField, ComparisonOperator comparisonOperator, string value)
        {
            Filters.Add(new Filter(filterOperator, SearchCodes[searchField], comparisonOperator, value));
        }

        private void AddFilter(FilterOperator filterOperator, T searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value)
        {
            Filters.Add(new Filter(filterOperator, SearchCodes[searchField], targetTableName, targetFieldCode, comparisonOperator, value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract Task<Results> Perform();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            for(var i = 0; i < Filters.Count; i++)
            {
                var filter = Filters[i];

                switch(filter.FilterOperator)
                {
                    case FilterOperator.And: stringBuilder.Append(" AND"); break;
                    case FilterOperator.Or: stringBuilder.Append(" OR"); break;
                    case FilterOperator.Not: stringBuilder.Append(" NOT"); break;
                    case FilterOperator.First:
                        if (i != 0)
                        {
                            throw new ArgumentOutOfRangeException("Only the first Search Filter can use the FilterOperator.First enum value.");
                        }
                        break;
                }

                // Can be any valid field value, invalid value will result on an error page.
                var tempValue = filter.Value;
                if (string.IsNullOrEmpty(tempValue))
                {
                    // Use the special value: $NULL$ to filter on Null values and $EMPTY$ to filter on empty string values. These two special values are not case sensitive.
                    tempValue = (filter.Value == null) ? "$NULL$" : "$EMPTY$";
                }

                // NOTE: These special values can only be used with the Equal and Different operators.
                if ((tempValue.Equals("$NULL$", StringComparison.InvariantCultureIgnoreCase) || tempValue.Equals("$EMPTY$", StringComparison.InvariantCultureIgnoreCase)) 
                    && filter.ComparisonOperator != ComparisonOperator.EqualTo && filter.ComparisonOperator != ComparisonOperator.Different)
                {
                    throw new ArgumentOutOfRangeException("$NULL$ and $EMPTY$ special values can only be used with the Equal and Different operators.");
                }

                string operatorValue = GetOperatorValue(filter.ComparisonOperator);
                if (filter.IsLinkField)
                {
                    stringBuilder.AppendFormat("{0}.{1}.{2}{3}{4}", filter.FieldCode, filter.TargetTableName, filter.TargetFieldCode, operatorValue, filter.Value);
                }
                else
                {
                    stringBuilder.AppendFormat("{0}{1}\"{2}\"", filter.FieldCode, operatorValue, filter.Value);
                }
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Helper method to get string values from the ComparisonOperator enum
        /// 
        /// NOTE: All operators are case sensitive.
        /// </summary>
        /// <param name="comparisonOperator"></param>
        /// <returns></returns>
        private string GetOperatorValue(ComparisonOperator comparisonOperator)
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
                default: throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Internal enum used by the search logic
        /// </summary>
        private enum FilterOperator
        {
            And,
            Or,
            Not,
            First // Used by the first filter, to indicate it doesn't need a filter join
        }

        /// <summary>
        /// 
        /// </summary>
        private struct Filter
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
}