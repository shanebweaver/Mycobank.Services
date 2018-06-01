using System.Collections.Generic;
using Mycobank.Services.Search.Enums;
using Mycobank.Services.Search.Models;

namespace Mycobank.Services.Search
{
    public class TaxaDescriptionsSearch : Search<TaxaDescriptionsSearchField, TaxaDescriptionsTaxon>
    {
        public override string TableName => "Taxa descriptions";
        protected override string KeyNumber => "14682616000000209";

        internal override IReadOnlyDictionary<TaxaDescriptionsSearchField, string> SearchCodes => TaxaDescriptionsSearchCodes;
        internal static IReadOnlyDictionary<TaxaDescriptionsSearchField, string> TaxaDescriptionsSearchCodes = new Dictionary<TaxaDescriptionsSearchField, string>
        {
            { TaxaDescriptionsSearchField._id, "_id" },
            { TaxaDescriptionsSearchField.CreationDate, "creation_date" },
            { TaxaDescriptionsSearchField.Description, "description_" },
            { TaxaDescriptionsSearchField.DescriptionType, "descriptiontype_" },
            { TaxaDescriptionsSearchField.JournalOrBook, "literaturejournalbook_" },
            { TaxaDescriptionsSearchField.LastModificationDate, "last_change_date" },
            { TaxaDescriptionsSearchField.LastModificationUser, "usermod" },
            { TaxaDescriptionsSearchField.LiteratureRemarks, "literatureremarks_" },
            { TaxaDescriptionsSearchField.Name, "name" },
            { TaxaDescriptionsSearchField.PageNumber, "literaturepagenr_" },
        };

        public TaxaDescriptionsSearch(TaxaDescriptionsSearchField searchField, ComparisonOperator comparisonOperator, string value, int? limit = null) : base(searchField, comparisonOperator, value, limit)
        {
        }

        public TaxaDescriptionsSearch(TaxaDescriptionsSearchField searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value, int? limit = null) : base(searchField, targetTableName, targetFieldCode, comparisonOperator, value, limit)
        {
        }
    }
}
