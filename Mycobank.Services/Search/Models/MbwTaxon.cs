using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    public partial class MbwTaxon : Taxon
    {
        [XmlElement("creation_date")]
        public string CreationDate { get; set; }

        [XmlElement("last_change_date")]
        public string LastChangeDate { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("epithet_")]
        public string Epithet { get; set; }

        [XmlElement("authors_")]
        public string Authors { get; set; }

        [XmlElement("nameyear_")]
        public string NameYear { get; set; }

        [XmlElement("mycobanknr_")]
        public string MycobankNumber { get; set; }

        [XmlElement("literatureremarks_")]
        public string LiteratureRemarks { get; set; }

        [XmlElement("literaturereferencetype_")]
        public string LiteratureReferenceType { get; set; }

        [XmlElement("literaturepagenr_")]
        public string LiteraturePageNumber { get; set; }

        [XmlArray("description_pt_")]
        [XmlArrayItem("TargetRecord", IsNullable = false)]
        public TargetRecord[] DescriptionParts { get; set; }

        [XmlElement("gender_")]
        public string Gender { get; set; }

        [XmlElement("e3787")]
        public string E3787 { get; set; }

        [XmlArray("u3733")]
        [XmlArrayItem("Link", IsNullable = false)]
        public Link[] E3733 { get; set; }
    }
}
