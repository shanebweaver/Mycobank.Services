using System.Collections.Generic;
using Mycobank.Services.Search.Enums;

namespace Mycobank.Services.Search
{
    /// <summary>
    /// 
    /// </summary>
    public enum MycobankSearchField
    {
        _id,
        Authors,
        AuthorsAbbreviated,
        Classification,
        CreationDate,
        Epithet,
        LastModificationDate,
        MycoBankNumber,
        Name,
        Summary,
        Synonymy,
        YearOfPublication,
        MainRank,
        NumberOfRecords,
        PreviousRank,
        PreviousRankRequired,
        PrimaryRank,
        RankEnglish,
        RankLatin,
        RankGroup,
        RankNumber,
        RankTermination,
        TypeRank,
        UseAbbreviation,
        UseUppercase,
        CollectorsNumber,
        MycoBankTypificationNumber,
        StrainNumbers
    }

    /// <summary>
    /// 
    /// </summary>
    public static class MycobankSearchExtensions
    {
        public static string SearchCode(this MycobankSearchField searchField)
        {
            return MycobankSearch.MycobankSearchCodes[searchField];
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class MycobankSearch : Search<MycobankSearchField>
    {
        protected override string TableName => "Mycobank";
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
            { MycobankSearchField.YearOfPublication, "nameyear_" },
            { MycobankSearchField.MainRank, "rank_pt_.taxons_ranks_.mainrank_" },
            { MycobankSearchField.NumberOfRecords, "rank_pt_.taxons_ranks_.nrrecords_" },
            { MycobankSearchField.PreviousRank, "rank_pt_.taxons_ranks_.prevrank_pt_" },
            { MycobankSearchField.PreviousRankRequired, "required  rank_pt_.taxons_ranks_.prevrequired_" },
            { MycobankSearchField.PrimaryRank, "rank_pt_.taxons_ranks_.primaryrank_" },
            { MycobankSearchField.RankEnglish, "rank_pt_.taxons_ranks_.rankenglish_" },
            { MycobankSearchField.RankLatin, "rank_pt_.taxons_ranks_.ranklatin_" },
            { MycobankSearchField.RankGroup, "rank_pt_.taxons_ranks_.rankgroup_" },
            { MycobankSearchField.RankNumber, "rank_pt_.taxons_ranks_.ranknr_" },
            { MycobankSearchField.RankTermination, "rank_pt_.taxons_ranks_.ranktermin_" },
            { MycobankSearchField.TypeRank, "rank_pt_.taxons_ranks_.typerank_pt_" },
            { MycobankSearchField.UseAbbreviation, "rank_pt_.taxons_ranks_.useabbrev_" },
            { MycobankSearchField.UseUppercase, "rank_pt_.taxons_ranks_.uppercase_" },
            { MycobankSearchField.CollectorsNumber, "specimen_pt_.taxons_specimens_.collectorsnumber_" },
            { MycobankSearchField.MycoBankTypificationNumber, "specimen_pt_.taxons_specimens_.d5033" },
            { MycobankSearchField.StrainNumbers, "specimen_pt_.taxons_specimens_.strainnumbers_" }
        };

        public MycobankSearch(MycobankSearchField searchField, ComparisonOperator comparisonOperator, string value, int? limit = null) : base(searchField, comparisonOperator, value, limit)
        {
        }

        public MycobankSearch(MycobankSearchField searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value, int? limit = null) : base(searchField, targetTableName, targetFieldCode, comparisonOperator, value, limit)
        {
        }
    }
}
