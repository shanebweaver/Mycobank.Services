using System.Xml.Serialization;

namespace Mycobank.Services.Search.Models
{
    public partial class MycobankTaxon : Taxon
    {
        [XmlElement("creation_date")]
        public string CreationDate { get; set; }

        [XmlElement("last_change_date")]
        public string LastChangeDate { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("e3787")]
        public string E3787 { get; set; }

        [XmlElement("e4060")]
        public string E4060 { get; set; }

        [XmlElement("mycobanknr_")]
        public uint MycobankNumber { get; set; }

        [XmlElement("epithet_")]
        public string Epithet { get; set; }

        [XmlElement("rank_pt_")]
        public TargetRecordItem Rank { get; set; }

        [XmlElement("orthvariantof_pt_")]
        public TargetRecord OrthvariantOf { get; set; }

        [XmlElement("authors_")]
        public string Authors { get; set; }

        [XmlElement("authorsabbrev_")]
        public string AuthorsAbbreviated { get; set; }

        [XmlElement("ethymology_")]
        public string Ethymology { get; set; }

        [XmlElement("literature_pt_")]
        public TargetRecordItem Literature { get; set; }

        [XmlElement("literaturepagenr_")]
        public string LiteraturePageNumber { get; set; }

        [XmlElement("literaturejournalbook_")]
        public string LiteratureJournalBook { get; set; }

        [XmlElement("nameyear_")]
        public string NameYear { get; set; }

        [XmlElement("nametype_")]
        public string NameType { get; set; }

        [XmlElement("gender_")]
        public string Gender { get; set; }

        [XmlElement("datepublic_")]
        public string DatePublic { get; set; }

        [XmlElement("namestatus_")]
        public string NameStatus { get; set; }

        [XmlElement("namestatusexplanation_")]
        public string NameStatusExplanation { get; set; }

        [XmlElement("remarks_")]
        public string Remarks { get; set; }

        [XmlElement("sanctioningref_")]
        public string SanctioningReference { get; set; }

        [XmlElement("sanctionedby_")]
        public string SanctionedBy { get; set; }

        [XmlElement("sanctioningname_pt_")]
        public TargetRecordItem SanctioningName { get; set; }

        [XmlElement("validatedby_pt_")]
        public TargetRecordItem ValidatedBy { get; set; }

        [XmlArray("specimen_pt_")]
        [XmlArrayItem("TargetRecord", IsNullable = false)]
        public TargetRecord[] Specimen { get; set; }

        [XmlArray("rlink4703")]
        [XmlArrayItem("TargetRecord", IsNullable = false)]
        public TargetRecord[] RLink4703 { get; set; }

        [XmlElement("humanpathogenicitycode_")]
        public string HumanPathogenicityCode { get; set; }

        [XmlElement("plantpathogenicitycode_")]
        public string PlantPathogenicityCode { get; set; }

        [XmlElement("codetoxicity_")]
        public string CodeToxicity { get; set; }

        [XmlElement("currentname_pt_")]
        private TargetRecordItem CurrentName { get; set; }

        [XmlArray("classification_")]
        [XmlArrayItem("ChildrenRecord", IsNullable = false)]
        public ChildrenRecord[] Classification { get; set; }

        [XmlElement("typename_pt_")]
        public TargetRecordItem TypeName { get; set; }

        [XmlElement("basedon_pt_")]
        public TargetRecordItem BasedOn { get; set; }

        [XmlArray("obligatesynonyms_pt_")]
        [XmlArrayItem("TargetRecord", IsNullable = false)]
        public TargetRecord[] ObligateSynonyms { get; set; }

        [XmlArray("anamorph_pt_")]
        [XmlArrayItem("TargetRecord", IsNullable = false)]
        public TargetRecord[] Anamorph { get; set; }

        [XmlArray("teleomorph_pt_")]
        [XmlArrayItem("TargetRecord", IsNullable = false)]
        public TargetRecord[] Teleomorph { get; set; }

        [XmlArray("facultativesynonyms_pt_")]
        [XmlArrayItem("TargetRecord", IsNullable = false)]
        public TargetRecord[] FacultativeSynonyms { get; set; }

        [XmlElement("v4912")]
        public string V4912 { get; set; }

        [XmlArray("description_pt_")]
        [XmlArrayItem("TargetRecord", IsNullable = false)]
        public TargetRecord[] Description { get; set; }

        [XmlElement("protolog_pt_")]
        public TargetRecordItem Protolog { get; set; }

        [XmlArray("externallinks_")]
        [XmlArrayItem("Link", IsNullable = false)]
        public Link[] ExternalLinks { get; set; }

        [XmlArray("u3732")]
        [XmlArrayItem("Link", IsNullable = false)]
        public Link[] U3732 { get; set; }

        [XmlArray("u3733")]
        [XmlArrayItem("Link", IsNullable = false)]
        public Link[] U3733 { get; set; }

        [XmlArray("u3734")]
        [XmlArrayItem("Link", IsNullable = false)]
        public Link[] U3734 { get; set; }

        [XmlArray("u3735")]
        [XmlArrayItem("Link", IsNullable = false)]
        public Link[] U3735 { get; set; }

        [XmlElement("files_pt_")]
        public TargetRecordItem Files { get; set; }
    }
}