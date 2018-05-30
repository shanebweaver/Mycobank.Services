using System.Collections.Generic;
using Mycobank.Services.Search.Enums;

namespace Mycobank.Services.Search
{
    /// <summary>
    /// 
    /// </summary>
    public enum TaxaDescriptionsSearchField
    {
        _id,
        CreationDate,
        Description,
        DescriptionType,
        JournalOrBook,
        LastModificationDate,
        LastModificationUser,
        LiteratureRemarks,
        Name,
        PageNumber
    }

    /// <summary>
    /// 
    /// </summary>
    public static class TaxaDescriptionsSearchExtensions
    {
        public static string SearchCode(this TaxaDescriptionsSearchField searchField)
        {
            return TaxaDescriptionsSearch.TaxaDescriptionsSearchCodes[searchField];
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class TaxaDescriptionsSearch : Search<TaxaDescriptionsSearchField>
    {
        protected override string TableName => "Taxa descriptions";
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
