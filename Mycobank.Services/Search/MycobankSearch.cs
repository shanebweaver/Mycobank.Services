using System.Collections.Generic;
using Mycobank.Services.Search.Enums;
using Mycobank.Services.Search.Models;

namespace Mycobank.Services.Search
{
    public class MycobankSearch : Search<MycobankSearchField, MycobankTaxon>
    {
        public override string TableName => "Mycobank";
        protected override string KeyNumber => "14682616000000161";

        internal override IReadOnlyDictionary<MycobankSearchField, string> SearchCodes => MycobankSearchCodes;
        internal static IReadOnlyDictionary<MycobankSearchField, string> MycobankSearchCodes = new Dictionary<MycobankSearchField, string>
        {
            { MycobankSearchField._id, "_id" },
            { MycobankSearchField.Authors, "authors_" },
            { MycobankSearchField.AuthorsAbbreviated, "authorsabbrev_" },
            { MycobankSearchField.Classification, "classification_" },
            { MycobankSearchField.CreationDate, "creation_date" },
            { MycobankSearchField.Epithet, "epithet_" },
            { MycobankSearchField.LastModificationDate, "last_change_date" },
            { MycobankSearchField.MycoBankNumber, "mycobanknr_" },
            { MycobankSearchField.Name, "name" },
            { MycobankSearchField.Summary, "e3787" },
            { MycobankSearchField.Synonymy, "e4060" },
            { MycobankSearchField.YearOfPublication, "nameyear_" }
        };

        public MycobankSearch(MycobankSearchField searchField, ComparisonOperator comparisonOperator, string value, int? limit = null) : base(searchField, comparisonOperator, value, limit)
        {
        }

        public MycobankSearch(MycobankSearchField searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value, int? limit = null) : base(searchField, targetTableName, targetFieldCode, comparisonOperator, value, limit)
        {
        }
    }
}
