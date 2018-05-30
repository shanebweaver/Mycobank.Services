using System.Collections.Generic;
using Mycobank.Services.Search.Enums;

namespace Mycobank.Services.Search
{
    /// <summary>
    /// 
    /// </summary>
    public enum MycobankLiteratureSearchField
    {
        _id,
        Abstract,
        Authors,
        CreationDate,
        Documenttype,
        DOI,
        Edition,
        Editors,
        FirstPage,
        Hyperlink,
        Hyperlink2,
        ISBN,
        Issue,
        JournalName,
        Keywords,
        LastModificationDate,
        LastModificationUser,
        LastPage,
        Name,
        Publisher,
        PubMedID,
        Series,
        Summary,
        Title,
        TitleAbbreviated,
        User,
        Volume,
        Year
    }

    /// <summary>
    /// 
    /// </summary>
    public static class MycobankLiteratureExtensions
    {
        public static string SearchCode(this MycobankLiteratureSearchField searchField)
        {
            return MycobankLiteratureSearch.MycobankLiteratureSearchCodes[searchField];
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class MycobankLiteratureSearch : Search<MycobankLiteratureSearchField>
    {
        protected override string TableName => "Mycobank literature";
        protected override string KeyNumber => "14682616000000163";

        internal override IReadOnlyDictionary<MycobankLiteratureSearchField, string> SearchCodes => MycobankLiteratureSearchCodes;
        internal static IReadOnlyDictionary<MycobankLiteratureSearchField, string> MycobankLiteratureSearchCodes = new Dictionary<MycobankLiteratureSearchField, string>
        {
            { MycobankLiteratureSearchField._id, "_id" },
            { MycobankLiteratureSearchField.Abstract, "abstract_" },
            { MycobankLiteratureSearchField.Authors, "authors_" },
            { MycobankLiteratureSearchField.CreationDate, "creation_date" },
            { MycobankLiteratureSearchField.Documenttype, "doctype_" },
            { MycobankLiteratureSearchField.DOI, "doi_" },
            { MycobankLiteratureSearchField.Edition, "edition_" },
            { MycobankLiteratureSearchField.Editors, "editors_" },
            { MycobankLiteratureSearchField.FirstPage, "pagefrom_" },
            { MycobankLiteratureSearchField.Hyperlink, "hyperlink_" },
            { MycobankLiteratureSearchField.Hyperlink2, "hyperlinkto_" },
            { MycobankLiteratureSearchField.ISBN, "isbn_" },
            { MycobankLiteratureSearchField.Issue, "issue_" },
            { MycobankLiteratureSearchField.JournalName, "e4332" },
            { MycobankLiteratureSearchField.Keywords, "keywords_" },
            { MycobankLiteratureSearchField.LastModificationDate, "last_change_date" },
            { MycobankLiteratureSearchField.LastModificationUser, "usermod" },
            { MycobankLiteratureSearchField.LastPage, "pageto_" },
            { MycobankLiteratureSearchField.Name, "name" },
            { MycobankLiteratureSearchField.Publisher, "publisher_" },
            { MycobankLiteratureSearchField.PubMedID, "pubmedid_" },
            { MycobankLiteratureSearchField.Series, "series_" },
            { MycobankLiteratureSearchField.Summary, "e3811" },
            { MycobankLiteratureSearchField.Title, "title_" },
            { MycobankLiteratureSearchField.TitleAbbreviated, "titleabbrev_" },
            { MycobankLiteratureSearchField.User, "user" },
            { MycobankLiteratureSearchField.Volume, "volume_" },
            { MycobankLiteratureSearchField.Year, "year_" }
        };

        public MycobankLiteratureSearch(MycobankLiteratureSearchField searchField, ComparisonOperator comparisonOperator, string value, int? limit = null) : base(searchField, comparisonOperator, value, limit)
        {
        }

        public MycobankLiteratureSearch(MycobankLiteratureSearchField searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value, int? limit = null) : base(searchField, targetTableName, targetFieldCode, comparisonOperator, value, limit)
        {
        }
    }
}
