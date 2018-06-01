using System.Collections.Generic;
using Mycobank.Services.Search.Enums;
using Mycobank.Services.Search.Models;

namespace Mycobank.Services.Search
{
    public class MBWSearch : Search<MBWSearchField, MbwTaxon>
    {
        public override string TableName => "MBWService";
        protected override string KeyNumber => "14682616000003562";

        internal override IReadOnlyDictionary<MBWSearchField, string> SearchCodes => MBWSearchCodes;
        internal static IReadOnlyDictionary<MBWSearchField, string> MBWSearchCodes = new Dictionary<MBWSearchField, string>
        {
            { MBWSearchField._id, "_id" },
            { MBWSearchField.Authors, "authors_" },
            { MBWSearchField.CreationDate, "creation_date" },
            { MBWSearchField.Epithet, "epithet_" },
            { MBWSearchField.Gender, "gender_" },
            { MBWSearchField.LastModificationDate, "last_change_date" },
            { MBWSearchField.MycoBankNumber, "mycobanknr_" },
            { MBWSearchField.Name, "name" },
            { MBWSearchField.Summary, "e3787" },
            { MBWSearchField.YearOfPublication, "nameyear_" }
        };

        public MBWSearch(MBWSearchField searchField, ComparisonOperator comparisonOperator, string value, int? limit = null) : base(searchField, comparisonOperator, value, limit)
        {
        }

        public MBWSearch(MBWSearchField searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value, int? limit = null) : base(searchField, targetTableName, targetFieldCode, comparisonOperator, value, limit)
        {
        }
    }
}
