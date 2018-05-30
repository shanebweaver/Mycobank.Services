using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class MbwTaxon : Taxon
    {
        [XmlElement("_id")]
        public byte Id { get; set; }

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
        public ushort NameYear { get; set; }

        [XmlElement("mycobanknr_")]
        public uint MycobankNumber { get; set; }

        [XmlElement("literatureremarks_")]
        public object LiteratureRemarks { get; set; }

        [XmlElement("literaturereferencetype_")]
        public object LiteratureReferenceType { get; set; }

        [XmlElement("literaturepagenr_")]
        public byte LiteraturePageNumber { get; set; }

        [XmlElement("description_pt_")]
        [XmlArrayItem("TargetRecord", IsNullable = false)]
        public TargetRecord[] DescriptionParts { get; set; }

        [XmlElement("gender_")]
        public string Gender { get; set; }

        [XmlElement("e3787")]
        public string E3787 { get; set; }

        [XmlElement("u3733")]
        [XmlArrayItem("Link", IsNullable = false)]
        public Link[] E3733 { get; set; }
    }
}
