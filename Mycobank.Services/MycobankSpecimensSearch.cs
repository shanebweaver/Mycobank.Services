using Mycobank.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mycobank.Services
{
    /// <summary>
    /// 
    /// </summary>
    public enum MycobankSpecimensSearchField
    {
        _id,
        CollectedBy,
        CollectionDate,
        CollectorsNumber,
        ConditionsForGrowth,
        ConditionsForSporulation,
        Host,
        IdentifiedBy,
        IsolatedBy,
        IsolationMethod,
        JournalOrBook,
        LastModificationDate,
        LastModificationUser,
        LiteratureRemarks,
        LocationDetails,
        MycoBankTypificationNumber,
        Name,
        Status,
        StrainNumbers,
        SubstrateDetails,
    }

    /// <summary>
    /// 
    /// </summary>
    public static class MycobankSpecimensSearchExtensions
    {
        public static string SearchCode(this MycobankSpecimensSearchField searchField)
        {
            return MycobankSpecimensSearch.MycobankSpecimensSearchCodes[searchField];
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class MycobankSpecimensSearch : Search<MycobankSpecimensSearchField>
    {
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

        public MycobankSpecimensSearch(MycobankSpecimensSearchField searchField, ComparisonOperator comparisonOperator, string value, int? limit = null)
            : base(searchField, comparisonOperator, value, limit)
        {

        }

        public MycobankSpecimensSearch(MycobankSpecimensSearchField searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value, int? limit = null)
            : base(searchField, comparisonOperator, value, limit)
        {

        }

        public override async Task<Results> Perform()
        {
            return await MycobankSpecimensService.Instance.Perform(this);
        }
    }
}
