using System.Collections.Generic;
using Mycobank.Services.Search.Enums;
using Mycobank.Services.Search.Models;

namespace Mycobank.Services.Search
{
    public class MycobankSpecimensSearch : Search<MycobankSpecimensSearchField, MycobankSpecimensTaxon>
    {
        public override string TableName => "Mycobank specimens";
        protected override string KeyNumber => "14682616000000205";

        internal override IReadOnlyDictionary<MycobankSpecimensSearchField, string> SearchCodes => MycobankSpecimensSearchCodes;
        internal static IReadOnlyDictionary<MycobankSpecimensSearchField, string> MycobankSpecimensSearchCodes = new Dictionary<MycobankSpecimensSearchField, string>
        {
            { MycobankSpecimensSearchField._id, "_id" },
            { MycobankSpecimensSearchField.CollectedBy, "collectedby_" },
            { MycobankSpecimensSearchField.CollectionDate, "collectiondate_" },
            { MycobankSpecimensSearchField.CollectorsNumber, "collectorsnumber_" },
            { MycobankSpecimensSearchField.ConditionsForGrowth, "conditionsforgrowth_" },
            { MycobankSpecimensSearchField.ConditionsForSporulation, "conditionsforsporulation_" },
            { MycobankSpecimensSearchField.Host, "host_" },
            { MycobankSpecimensSearchField.IdentifiedBy, "identifiedby_" },
            { MycobankSpecimensSearchField.IsolatedBy, "isolatedby_" },
            { MycobankSpecimensSearchField.IsolationMethod, "isolationmethod_" },
            { MycobankSpecimensSearchField.JournalOrBook, "literaturejournalbook_" },
            { MycobankSpecimensSearchField.LastModificationDate, "last_change_date" },
            { MycobankSpecimensSearchField.LastModificationUser, "usermod" },
            { MycobankSpecimensSearchField.LiteratureRemarks, "literatureremarks_" },
            { MycobankSpecimensSearchField.LocationDetails, "locationdetails_" },
            { MycobankSpecimensSearchField.MycoBankTypificationNumber, "d5033" },
            { MycobankSpecimensSearchField.Name, "name" },
            { MycobankSpecimensSearchField.Status, "status_" },
            { MycobankSpecimensSearchField.StrainNumbers, "strainnumbers_" },
            { MycobankSpecimensSearchField.SubstrateDetails, "substratedetails_" },
        };

        public MycobankSpecimensSearch(MycobankSpecimensSearchField searchField, ComparisonOperator comparisonOperator, string value, int? limit = null) : base(searchField, comparisonOperator, value, limit)
        {
        }

        public MycobankSpecimensSearch(MycobankSpecimensSearchField searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value, int? limit = null) : base(searchField, targetTableName, targetFieldCode, comparisonOperator, value, limit)
        {
        }
    }
}
