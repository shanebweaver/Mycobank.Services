using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class TaxaDescriptionsTaxon : Taxon
    {
        [XmlElement("creation_date")]
        public string CreationDate { get; set; }

        [XmlElement("last_change_date")]
        public string LastChangeDate { get; set; }

        [XmlElement("usermod")]
        public string UserMod { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("citation_pt_")]
        public object Citation { get; set; }

        [XmlElement("literatureremarks_")]
        public object LiteratureRemarks { get; set; }

        [XmlElement("literature_pt_")]
        public TargetRecordItem Literature { get; set; }

        [XmlElement("literaturereferencetype_")]
        public object LiteratureReferenceType { get; set; }

        [XmlElement("literaturepagenr_")]
        public ushort LiteraturePageNumber { get; set; }

        [XmlElement("literaturejournalbook_")]
        public object LiteratureJournalBook { get; set; }

        [XmlElement("remarksinternet_")]
        public object RemarksInternet { get; set; }

        [XmlElement("remarks_")]
        public object Remarks { get; set; }

        [XmlElement("descriptiontype_")]
        public string DescriptionType { get; set; }

        [XmlElement("description_")]
        public string Description { get; set; }

        [XmlElement("rlink3626")]
        private TargetRecordItem _rlink3626 { get; set; }

        [XmlIgnore]
        private TargetRecord Rlink3626 => _rlink3626.TargetRecord;
    }
}
