using Mycobank.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mycobank.Services
{
    /// <summary>
    /// 
    /// </summary>
    public enum MBWSearchField
    {
        _id,
        Authors,
        CreationDate,
        Epithet,
        Gender,
        LastModificationDate,
        MycoBankNumber,
        Name,
        Summary,
        YearOfPublication,
        Citation,
        Description,
        DescriptionType,
        JournalOrBook,
        LiteratureRemarks,
        PageNumber,
        ReferenceType,
        Remarks_Internal,
        Remarks_Public,
    }

    /// <summary>
    /// 
    /// </summary>
    public static class MBWSearchExtensions
    {
        public static string SearchCode(this MBWSearchField searchField)
        {
            return MBWSearch.MBWSearchCodes[searchField];
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class MBWSearch : Search<MBWSearchField>
    {
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
            { MBWSearchField.YearOfPublication, "nameyear_" },
            { MBWSearchField.Citation, "description_pt_.taxons_descriptions_.citation_pt_" },
            { MBWSearchField.Description, "description_pt_.taxons_descriptions_.description_" },
            { MBWSearchField.DescriptionType, "description_pt_.taxons_descriptions_.descriptiontype_" },
            { MBWSearchField.JournalOrBook, "description_pt_.taxons_descriptions_.literaturejournalbook_" },
            { MBWSearchField.LiteratureRemarks, "description_pt_.taxons_descriptions_.literatureremarks_" },
            { MBWSearchField.PageNumber, "description_pt_.taxons_descriptions_.literaturepagenr_" },
            { MBWSearchField.ReferenceType, "description_pt_.taxons_descriptions_.literaturereferencetype_" },
            { MBWSearchField.Remarks_Internal, "description_pt_.taxons_descriptions_.remarks_" },
            { MBWSearchField.Remarks_Public, "description_pt_.taxons_descriptions_.remarksinternet_" }
        };

        public MBWSearch(MBWSearchField searchField, ComparisonOperator comparisonOperator, string value, int? limit = null)
            : base(searchField, comparisonOperator, value, limit)
        {
            
        }

        public MBWSearch(MBWSearchField searchField, string targetTableName, string targetFieldCode, ComparisonOperator comparisonOperator, string value, int? limit = null) 
            : base(searchField, comparisonOperator, value, limit)
        {

        }

        public override async Task<Results> Perform()
        {
            return await MBWService.Instance.Perform(this);
        }
    }
}
