using Mycobank.Services.Search.Enums;
using Mycobank.Services.Search.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mycobank.Services.Search
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract partial class Search<T, T2> where T2 : Taxon
    {
        private static readonly Uri SERVER_ADDRESS = new Uri("http://www.mycobank.org/Services/Generic/SearchService.svc/rest/xml");

        public abstract string TableName { get; }
        protected abstract string KeyNumber { get; }

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

        internal Search<T, T2> And(T searchField, ComparisonOperator comparisonOperator, string value)
        {
            AddFilter(FilterOperator.And, searchField, comparisonOperator, value);
            return this;
        }

        internal Search<T, T2> And(T searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value)
        {
            AddFilter(FilterOperator.And, searchField, targetTableName, targetFieldCode, comparisonOperator, value);
            return this;
        }

        internal Search<T, T2> Or(T searchField, ComparisonOperator comparisonOperator, string value)
        {
            AddFilter(FilterOperator.Or, searchField, comparisonOperator, value);
            return this;
        }

        internal Search<T, T2> Or(T searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value)
        {
            AddFilter(FilterOperator.Or, searchField, targetTableName, targetFieldCode, comparisonOperator, value);
            return this;
        }

        internal Search<T, T2> Not(T searchField, ComparisonOperator comparisonOperator, string value)
        {
            AddFilter(FilterOperator.Not, searchField, comparisonOperator, value);
            return this;
        }

        internal Search<T, T2> Not(T searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value)
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

        public async Task<Results<T2>> Perform()
        {
            var requestStringBuilder = new StringBuilder($"?layout={KeyNumber}&filter={ToString()}");
            if (Limit != null)
            {
                requestStringBuilder.Append($"&limit={Limit}");
            }

            var requestUri = new Uri(SERVER_ADDRESS, requestStringBuilder.ToString());

            Results<T2> returnValue = null;

            try
            {
                //Send the GET request asynchronously and retrieve the response as a string.
                var httpClient = new Windows.Web.Http.HttpClient();
                var httpResponse = new Windows.Web.Http.HttpResponseMessage();
                httpResponse = await httpClient.GetAsync(requestUri);
                httpResponse.EnsureSuccessStatusCode();

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Results<T2>));
                using (var inputStream = await httpResponse.Content.ReadAsInputStreamAsync())
                {
                    returnValue = (Results<T2>)xmlSerializer.Deserialize(inputStream.AsStreamForRead());
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message);
            }

            return returnValue;
        }

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

                string operatorValue = filter.ComparisonOperator.GetOperatorValue();
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
    }
}